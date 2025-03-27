namespace WinFormsApp2
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            txtHo = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            lblHoTen = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtHo);
            panel2.Location = new Point(75, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 38);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(121, 3);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(512, 31);
            txtHo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTen);
            panel3.Location = new Point(75, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 38);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.MistyRose;
            txtTen.Location = new Point(121, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(512, 31);
            txtTen.TabIndex = 0;
            // 
            // btnHo
            // 
            btnHo.FlatStyle = FlatStyle.Flat;
            btnHo.Location = new Point(78, 235);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(144, 64);
            btnHo.TabIndex = 3;
            btnHo.Text = "&Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.FlatStyle = FlatStyle.Flat;
            btnTen.Location = new Point(322, 235);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(144, 64);
            btnTen.TabIndex = 4;
            btnTen.Text = "&Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.FlatStyle = FlatStyle.Flat;
            btnHoTen.Location = new Point(564, 235);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(144, 64);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.FlatStyle = FlatStyle.Flat;
            btnKetThuc.Location = new Point(274, 345);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(231, 45);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.Highlight;
            lblHoTen.Location = new Point(-17, -7);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(819, 82);
            lblHoTen.TabIndex = 7;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Bai3";
            Text = "Bài Tập Họ Tên";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtHo;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label lblHoTen;
    }
}