using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnBrower_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            //Set filters for graphics files 
            ofdPicture.Filter = "Image Files (BMP, GIF, JPEG, etc.)|" +
                "*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|" + "BMP Files (*.bmp)|*.bmp|" +
                "GIF Files (*.gif)|*.gif|" + "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG Files (*.png)|*.png|" + "TIF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
                "All Files (*.*)|*.*";
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                //Get file information  
                FileInfo file = new FileInfo(ofdPicture.FileName);
                lblSize.Text = String.Format("File Size: {0} Bytes", file.Length.ToString());
                lblDateModified.Text = String.Format("Date last modified: {0}",
file.LastWriteTime.ToLongDateString());
                lblDateAccessed.Text = String.Format("Date last accessed: {0}",
file.LastAccessTime.ToLongDateString());
                //Load the file contents in the PictureBox  
                this.pbImage.Image = new Bitmap(ofdPicture.FileName);
            }
        }
    }
}
