namespace WinFormsApp2
{
    partial class StepByStep2_7
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
            lnkWinForms = new LinkLabel();
            lnkPrograms = new LinkLabel();
            SuspendLayout();
            // 
            // lnkWinForms
            // 
            lnkWinForms.AutoSize = true;
            lnkWinForms.Location = new Point(119, 105);
            lnkWinForms.Name = "lnkWinForms";
            lnkWinForms.Size = new Size(299, 25);
            lnkWinForms.TabIndex = 0;
            lnkWinForms.TabStop = true;
            lnkWinForms.Text = "Window Forms Community Website";
            // 
            // lnkPrograms
            // 
            lnkPrograms.AutoSize = true;
            lnkPrograms.Location = new Point(133, 231);
            lnkPrograms.Name = "lnkPrograms";
            lnkPrograms.Size = new Size(274, 25);
            lnkPrograms.TabIndex = 1;
            lnkPrograms.TabStop = true;
            lnkPrograms.Text = "Launch Calculator | Open C: Drive";
            lnkPrograms.TextAlign = ContentAlignment.TopRight;
            // 
            // StepByStep2_7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(lnkPrograms);
            Controls.Add(lnkWinForms);
            Name = "StepByStep2_7";
            Text = "Bai9";
            Load += Bai9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkWinForms;
        private LinkLabel lnkPrograms;
    }
}