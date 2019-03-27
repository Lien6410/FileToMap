using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gfl;
using System.Diagnostics;

namespace FileToMap
{
    public partial class Form1 : Form
    {
        private Wrapper wrapper;
        ChartForm chartForm;        

        public Form1()
        {
            InitializeComponent();
            wrapper = Wrapper.GetInstance();
            chartForm = new ChartForm();
        }

        private void btnOpenTxtFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select file";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                wrapper.SrcFileFullPath = openFileDialog1.FileName;
                txtOpenFilePath.Text = openFileDialog1.SafeFileName;

                wrapper.LoadTxtFile();
                wrapper.TxtIntoChart();

                //label1.Text = inputFile.SaveName + " is saved.";
            }
        }

        public delegate void InvokeCallback(string aText);
        
        public void RenewLabel1Text(string aText)
        {
            if (this.InvokeRequired)
            {
                InvokeCallback handler = new InvokeCallback(RenewLabel1Text);
                this.Invoke(handler, aText);
            }
            else
            {
                label1.Text = aText + " is saved.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jpegfile = "Waves.jpg";
            string jpegOutputfile = "Waves_R90.jpg";
            //if (pictureBox1.Image != null) pictureBox1.Image.Dispose(); //to unlock the file
            //GflAPI.JpegLosslessTransform(jpegfile, GFL_LOSSLESS_TRANSFORM.ROTATE90);
            //GflAPI.JpegLosslessTransform(jpegfile, jpegOutputfile, GFL_LOSSLESS_TRANSFORM.ROTATE90, true);
            //pictureBox1.Image = new Bitmap(jpegOutputfile);


            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"D:\YimingLien2018\ImageProcessing\XSoft NConvert\NConvert-win64\XnView\nconvert.exe";
            info.Arguments = "-out gif -dither -colors 256 house.png";
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process pro = Process.Start(info);
            pro.WaitForExit();

        }
    }
}
