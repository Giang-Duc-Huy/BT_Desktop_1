namespace WinFormsApp2
{
    partial class Bai5
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
            panel1 = new Panel();
            txtNhapTen = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            lblLapTrinh = new Label();
            button1 = new Button();
            label2 = new Label();
            panel3 = new Panel();
            radRed = new RadioButton();
            label4 = new Label();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            label3 = new Label();
            chkBold = new CheckBox();
            chkItalic = new CheckBox();
            label5 = new Label();
            panel4 = new Panel();
            chkUnderline = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNhapTen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 35);
            panel1.TabIndex = 0;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(98, 3);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(386, 31);
            txtNhapTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblLapTrinh);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 65);
            panel2.TabIndex = 2;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.Location = new Point(174, 13);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(247, 41);
            lblLapTrinh.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(425, 1);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 2;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(20, 13);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "Lập Trình Bởi:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(radRed);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(radBlack);
            panel3.Controls.Add(radBlue);
            panel3.Controls.Add(radGreen);
            panel3.Location = new Point(35, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 245);
            panel3.TabIndex = 3;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(17, 33);
            radRed.Name = "radRed";
            radRed.Size = new Size(70, 29);
            radRed.TabIndex = 6;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 5;
            label4.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(17, 193);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(83, 29);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(17, 138);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(75, 29);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(17, 85);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(88, 29);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, -2);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 4;
            label3.Text = "Font";
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(15, 31);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(121, 29);
            chkBold.TabIndex = 5;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(15, 83);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(160, 29);
            chkItalic.TabIndex = 6;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 108);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(chkUnderline);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(chkItalic);
            panel4.Controls.Add(chkBold);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(290, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 245);
            panel4.TabIndex = 4;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.ForeColor = Color.Blue;
            chkUnderline.Location = new Point(15, 137);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(129, 29);
            chkUnderline.TabIndex = 8;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Bai5";
            Text = "Định dạng(Formater)";
            Load += Bai5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNhapTen;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private Panel panel3;
        private RadioButton radGreen;
        private RadioButton radioButton1;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private Button button1;
        private Label label4;
        private Label label3;
        private CheckBox chkBold;
        private CheckBox chkItalic;
        private Label label5;
        private Panel panel4;
        private CheckBox chkUnderline;
        private Label lblLapTrinh;
        private RadioButton radRed;
    }
}