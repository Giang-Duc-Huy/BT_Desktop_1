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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ vào ô Name
            txtName.Focus();

            // Ẩn hình nhỏ khi load form
            picSmall.Visible = false;

            // Thêm Tooltip cho hình CDRom
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picBig, "Click Me");
            toolTip.SetToolTip(picSmall, "Click Me");
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked) lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked) lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked) lblMessage.ForeColor = Color.Black;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn Enter để hiển thị nội dung
            if (e.KeyCode == Keys.Enter)
            {
                btnDisplay_Click(sender, e);
            }

            // Nhấn Esc để thoát
            if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }
    }
}

