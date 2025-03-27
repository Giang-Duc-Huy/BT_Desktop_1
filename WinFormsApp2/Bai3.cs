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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHoTen.PerformClick(); // Giả lập click vào btnHoTen
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnKetThuc.PerformClick(); // Giả lập click vào btnKetThuc
            }
        }
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text + " " + txtHo;

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = btnTen.Text;

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
