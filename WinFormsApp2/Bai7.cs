using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Bai7 : Form
    {
        ToolTip toolTip = new ToolTip();
        public Bai7()
        {
            InitializeComponent();
        }
        private void Bai7_Load(object sender, EventArgs e)
        {
            // Căn giữa Form khi chạy
            this.StartPosition = FormStartPosition.CenterScreen;

            // Thiết lập giá trị mặc định
            textBox1.Text = "Jack";
            label1.Text = textBox1.Text + " Turn Off the Light ,please!";

            // Ẩn picTurnOff ban đầu
            picTurnOff.Visible = false;

            // Thêm ToolTip
            toolTip.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
            toolTip.SetToolTip(picTurnOff, "Click me to Turn ON the Light!");
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            label1.Text = textBox1.Text + " Turn On the Light ,please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;
            label1.Text = textBox1.Text + " Turn Off the Light ,please!";
        }




    }
}

