using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Sync
{
    public partial class Form1 : Form
    {
        public Form1() {  InitializeComponent(); }
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();


        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = ofd.FileName;
                    textBox1.Text = filePath;
                }
            } else if (radioButton2.Checked == true )
            {
                
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    textBox1.Text = folderPath;
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
