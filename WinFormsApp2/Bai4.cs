using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Bai4 : Form
    {
        // Khai báo tỷ giá
        private const double USD_RATE = 17861;
        private const double EUR_RATE = 27043;

        public Bai4()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra dữ liệu nhập vào có phải số không
        private bool IsValidInput(out double amount)
        {
            bool isValid = double.TryParse(textBox1.Text, out amount);
            if (!isValid)
            {
                errorProvider1.SetError(textBox1, "Vui lòng nhập số hợp lệ!");
            }
            else
            {
                errorProvider1.Clear();
            }
            return isValid;
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            if (IsValidInput(out double amount))
            {
                double result = Math.Round(amount / USD_RATE, 2);
                textBox2.Text = result.ToString() + " USD";
            }
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            if (IsValidInput(out double amount))
            {
                double result = Math.Round(amount * USD_RATE, 2);
                textBox2.Text = result.ToString() + " VND";
            }
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            if (IsValidInput(out double amount))
            {
                double result = Math.Round(amount / EUR_RATE, 2);
                textBox2.Text = result.ToString() + " EUR";
            }
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            if (IsValidInput(out double amount))
            {
                double result = Math.Round(amount * EUR_RATE, 2);
                textBox2.Text = result.ToString() + " VND";
            }
        }

        private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
