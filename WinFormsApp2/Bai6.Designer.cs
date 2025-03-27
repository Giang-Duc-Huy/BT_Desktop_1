namespace WinFormsApp2
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            txtMessage = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            lblMessage = new Panel();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            chkVisible = new CheckBox();
            picSmall = new PictureBox();
            picBig = new PictureBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(22, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Name & Message";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMessage);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(54, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 38);
            panel2.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(255, 224, 192);
            txtMessage.Location = new Point(136, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(520, 31);
            txtMessage.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Message:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 38);
            panel1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 224, 192);
            txtName.Location = new Point(136, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(520, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(radBlack);
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radRed);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(22, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(39, 176);
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
            radBlue.Location = new Point(39, 128);
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
            radGreen.Location = new Point(34, 83);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(88, 29);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(39, 39);
            radRed.Name = "radRed";
            radRed.Size = new Size(70, 29);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(255, 192, 192);
            lblMessage.Location = new Point(-14, 494);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(819, 49);
            lblMessage.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDisplay);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Location = new Point(526, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 267);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.Location = new Point(70, 174);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 46);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Location = new Point(70, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 51);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.ControlLight;
            btnDisplay.Location = new Point(70, 30);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(112, 53);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "&Display";
            btnDisplay.UseVisualStyleBackColor = false;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Location = new Point(312, 213);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(164, 29);
            chkVisible.TabIndex = 3;
            chkVisible.Text = "Message Visible";
            chkVisible.UseVisualStyleBackColor = true;
            // 
            // picSmall
            // 
            picSmall.BackgroundImage = (Image)resources.GetObject("picSmall.BackgroundImage");
            picSmall.BackgroundImageLayout = ImageLayout.Stretch;
            picSmall.Location = new Point(354, 248);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(108, 115);
            picSmall.TabIndex = 4;
            picSmall.TabStop = false;
            // 
            // picBig
            // 
            picBig.BackgroundImage = (Image)resources.GetObject("picBig.BackgroundImage");
            picBig.BackgroundImageLayout = ImageLayout.Stretch;
            picBig.Location = new Point(312, 316);
            picBig.Name = "picBig";
            picBig.Size = new Size(184, 164);
            picBig.TabIndex = 5;
            picBig.TabStop = false;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(picBig);
            Controls.Add(picSmall);
            Controls.Add(chkVisible);
            Controls.Add(groupBox3);
            Controls.Add(lblMessage);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bai6";
            Text = "Bai6";
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox txtMessage;
        private Label label2;
        private Panel panel1;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBox2;
        private Panel lblMessage;
        private GroupBox groupBox3;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private Button btnExit;
        private Button btnClear;
        private Button btnDisplay;
        private CheckBox chkVisible;
        private PictureBox picSmall;
        private PictureBox picBig;
    }
}