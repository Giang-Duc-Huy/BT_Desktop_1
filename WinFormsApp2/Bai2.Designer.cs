namespace WinFormsApp2
{
    partial class frmBaiTap1
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
            txtYourName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtYear = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnShow = new Button();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtYourName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(124, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 52);
            panel1.TabIndex = 0;
            // 
            // txtYourName
            // 
            txtYourName.BorderStyle = BorderStyle.FixedSingle;
            txtYourName.Location = new Point(150, 13);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(387, 31);
            txtYourName.TabIndex = 1;
            txtYourName.Leave += txtYourName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "Your Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtYear);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(124, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 52);
            panel2.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(150, 13);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(387, 31);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 2;
            label2.Text = "Year of Birth:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(641, 374);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(360, 374);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 4;
            btnShow.Text = "&Show\r\n";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(500, 374);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBaiTap1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmBaiTap1";
            Text = "My Name Project";
            FormClosing += frmBaiTap1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtYourName;
        private Label label1;
        private Panel panel2;
        private TextBox txtYear;
        private Label label2;
        private Button btnExit;
        private Button btnShow;
        private Button btnClear;
        private ErrorProvider errorProvider1;
    }
}