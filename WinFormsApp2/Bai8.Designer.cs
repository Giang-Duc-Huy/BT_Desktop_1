namespace WinFormsApp2
{
    partial class Bai8
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtA = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtB = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtNghiem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnTinh = new Button();
            btnXoa = new Button();
            btn_Thoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtA);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 47);
            panel1.TabIndex = 0;
            // 
            // txtA
            // 
            txtA.Location = new Point(148, 9);
            txtA.Name = "txtA";
            txtA.Size = new Size(491, 31);
            txtA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập A:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtB);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(58, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 47);
            panel2.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(148, 9);
            txtB.Name = "txtB";
            txtB.Size = new Size(491, 31);
            txtB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 15);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 0;
            label2.Text = "Nhập B:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtNghiem);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(58, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 47);
            panel3.TabIndex = 2;
            // 
            // txtNghiem
            // 
            txtNghiem.Location = new Point(148, 9);
            txtNghiem.Name = "txtNghiem";
            txtNghiem.Size = new Size(491, 31);
            txtNghiem.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 15);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 0;
            label3.Text = "Nghiệm PT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(227, 51);
            label4.Name = "label4";
            label4.Size = new Size(341, 32);
            label4.TabIndex = 3;
            label4.Text = "PHƯƠNG TRÌNH: AX + B = 0";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(206, 351);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 34);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "&Tính";
            btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(392, 351);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(585, 351);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(112, 34);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Th&oát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Thoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Bai8";
            Text = "Bai8";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtA;
        private Label label1;
        private Panel panel2;
        private TextBox txtB;
        private Label label2;
        private Panel panel3;
        private TextBox txtNghiem;
        private Label label3;
        private Label label4;
        private Button btnTinh;
        private Button btnXoa;
        private Button btn_Thoat;
        private ErrorProvider errorProvider1;
    }
}