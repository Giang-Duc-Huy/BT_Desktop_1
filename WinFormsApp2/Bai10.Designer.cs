namespace WinFormsApp2
{
    partial class Bai10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai10));
            label1 = new Label();
            btnBrowser = new Button();
            groupBox1 = new GroupBox();
            lblDateAccessed = new Label();
            lblDateModified = new Label();
            lblSize = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pbImage = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            kkkk = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 0;
            label1.Text = "Click button to open a file:";
            // 
            // btnBrowser
            // 
            btnBrowser.FlatStyle = FlatStyle.Popup;
            btnBrowser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowser.Location = new Point(449, 35);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(112, 34);
            btnBrowser.TabIndex = 1;
            btnBrowser.Text = "Browse...";
            btnBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(lblDateAccessed);
            groupBox1.Controls.Add(lblDateModified);
            groupBox1.Controls.Add(lblSize);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(35, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 236);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblDateAccessed
            // 
            lblDateAccessed.AutoSize = true;
            lblDateAccessed.Location = new Point(227, 183);
            lblDateAccessed.Name = "lblDateAccessed";
            lblDateAccessed.Size = new Size(0, 25);
            lblDateAccessed.TabIndex = 8;
            // 
            // lblDateModified
            // 
            lblDateModified.AutoSize = true;
            lblDateModified.Location = new Point(227, 122);
            lblDateModified.Name = "lblDateModified";
            lblDateModified.Size = new Size(0, 25);
            lblDateModified.TabIndex = 7;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(127, 60);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 25);
            lblSize.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(6, 183);
            label4.Name = "label4";
            label4.Size = new Size(193, 30);
            label4.TabIndex = 6;
            label4.Text = "Date last accessed:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(194, 30);
            label3.TabIndex = 5;
            label3.Text = "Date last modified:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 30);
            label2.TabIndex = 4;
            label2.Text = "Size:";
            // 
            // pbImage
            // 
            pbImage.Anchor = AnchorStyles.Top;
            pbImage.BackgroundImage = (Image)resources.GetObject("pbImage.BackgroundImage");
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbImage.Location = new Point(91, 382);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(794, 420);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // kkkk
            // 
            kkkk.AutoScroll = true;
            kkkk.Location = new Point(35, 358);
            kkkk.Name = "kkkk";
            kkkk.Size = new Size(526, 273);
            kkkk.TabIndex = 9;
            // 
            // Bai10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 657);
            Controls.Add(pbImage);
            Controls.Add(kkkk);
            Controls.Add(groupBox1);
            Controls.Add(btnBrowser);
            Controls.Add(label1);
            Name = "Bai10";
            Text = "Bai10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBrowser;
        private GroupBox groupBox1;
        private Label lblDateAccessed;
        private Label lblDateModified;
        private Label lblSize;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pbImage;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel kkkk;
    }
}