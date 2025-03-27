namespace WinFormsApp2
{
    partial class frmSimpleEvent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(237, 144);
            button2.Name = "button2";
            button2.Size = new Size(329, 139);
            button2.TabIndex = 1;
            button2.Text = "Click Me";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmSimpleEvent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSimpleEvent";
            Text = "frmSimpleEvent";
            Load += frmSimpleEvent_Load;
            Click += frmSimpleEvent_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
    }
}
