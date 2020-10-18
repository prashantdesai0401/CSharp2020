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

namespace MyPictureViewer
{
    public partial class Form1 : Form
    {
        string dirPath;
        static int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //show the open file dialog window, if user selects
            //an image file load that file into the picturebox.
           
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dirPath = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
                nextButton.Enabled = true;
            }
            else
            {

            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the picture.
            //by setting the image property of the piocturebox to null.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //show the color dialog
            //if user selects a color then
            //set that color as background color of the picture box.
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form.
            //as we are closing the parent form, 
            //entire APP gets exited/closed
            this.Close();
        }

        private void stretchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(stretchCheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Throws exception if the directory contains other than image files.

            FileInfo fInfo = new FileInfo(dirPath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.jpg");
            //MessageBox.Show(lFiles.Length.ToString());
            if (i < lFiles.Length)
                pictureBox1.Load(lFiles[i++].FullName);
            else
            { 
                i = 0;
                pictureBox1.Load(lFiles[i++].FullName);
            }

        }
    }
}
