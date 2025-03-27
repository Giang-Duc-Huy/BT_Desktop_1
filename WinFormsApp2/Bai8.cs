using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        private void Bai8_Load(object sender, EventArgs e)
        {
            btnTinh.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            double a, b;
            bool isValidA = double.TryParse(txtA.Text, out a);
            bool isValidB = double.TryParse(txtB.Text, out b);

            if (!isValidA)
                errorProvider1.SetError(txtA, "Vui lòng nhập số hợp lệ!");
            else
                errorProvider1.SetError(txtA, "");

            if (!isValidB)
                errorProvider1.SetError(txtB, "Vui lòng nhập số hợp lệ!");
            else
                errorProvider1.SetError(txtB, "");

            btnTinh.Enabled = isValidA && isValidB;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (a == 0)
            {
                if (b == 0)
                    txtNghiem.Text = "Vô số nghiệm";
                else
                    txtNghiem.Text = "Vô nghiệm";
            }
            else
            {
                double x = -b / a;
                txtNghiem.Text = "x = " + x.ToString("0.##");
            }

            btnXoa.Enabled = true;
            btnTinh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            txtA.Focus();
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
