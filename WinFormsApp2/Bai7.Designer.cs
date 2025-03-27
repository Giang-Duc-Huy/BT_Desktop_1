namespace WinFormsApp2
{
    partial class Bai7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai7));
            label1 = new Label();
            textBox1 = new TextBox();
            picTurnOn = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            picTurnOff = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTurnOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 1;
            // 
            // picTurnOn
            // 
            picTurnOn.BackgroundImage = (Image)resources.GetObject("picTurnOn.BackgroundImage");
            picTurnOn.Location = new Point(183, 75);
            picTurnOn.Name = "picTurnOn";
            picTurnOn.Size = new Size(150, 217);
            picTurnOn.TabIndex = 2;
            picTurnOn.TabStop = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(52, 311);
            label2.Name = "label2";
            label2.Size = new Size(386, 74);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 410);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Designed by:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 255);
            textBox2.Location = new Point(150, 407);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 31);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(339, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // picTurnOff
            // 
            picTurnOff.BackgroundImage = (Image)resources.GetObject("picTurnOff.BackgroundImage");
            picTurnOff.BackgroundImageLayout = ImageLayout.Stretch;
            picTurnOff.Location = new Point(183, 75);
            picTurnOff.Name = "picTurnOff";
            picTurnOff.Size = new Size(150, 217);
            picTurnOff.TabIndex = 7;
            picTurnOff.TabStop = false;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(483, 450);
            Controls.Add(picTurnOff);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picTurnOn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Bai7";
            Text = "Bai7";
            Load += Bai7_Load;
            ((System.ComponentModel.ISupportInitialize)picTurnOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox picTurnOn;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private PictureBox picTurnOff;
    }
}