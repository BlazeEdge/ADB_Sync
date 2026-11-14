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
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = ofd.FileName;
                    textBox1.Text = filePath;
                }
            } else if (radioButton2.Checked == true )
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                }
            }
        }
    }
}
