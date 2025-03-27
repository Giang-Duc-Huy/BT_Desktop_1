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
    public partial class StepByStep2_7 : Form
    {
        public StepByStep2_7()
        {
            InitializeComponent();
            //Add a link for Calculator in the first half of LinkLabel 
            lnkPrograms.Links.Add(0, "Launch Calculator".Length, "calc.exe ");
            //Add a link for C: Drive in 
            //the second half of LinkLabel 
            lnkPrograms.Links.Add(lnkPrograms.Text.IndexOf(
            "Open C: Drive"), "Open C: Drive".Length, "c:\\");
            //Autosize the control based on its contents 
            lnkPrograms.AutoSize = true;
        }
        private void lnkWinForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWinForms.LinkVisited = true;
        //Go to Windows Forms Community Website 
System.Diagnostics.Process.Start("FireFox", "http://www.windowsforms.net");
        }
        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Launch the program stored in the hyperlink 
            System.Diagnostics.Process.Start(
            e.Link.LinkData.ToString());
        }

        private void Bai9_Load(object sender, EventArgs e)
        {

        }
    }
}
