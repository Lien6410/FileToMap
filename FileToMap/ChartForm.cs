using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Gfl;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace FileToMap
{
    public partial class ChartForm : Form
    {
        private Wrapper wrapper;
        private Image image;
        private string saveNameWithTail;

        public ChartForm()
        {
            InitializeComponent();
            InitialChart();
            wrapper = Wrapper.GetInstance();
        }

        private void InitialChart()
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();

            for (int i = 0; i < 21; i++)
            {
                chart1.Series.Add("Level" + i.ToString());
                chart1.Series[i].ChartType = SeriesChartType.Point;
                int colorPara = i * 20;
                if (colorPara > 255) colorPara = 255;
                chart1.Series[i].Color = Color.FromArgb(colorPara, colorPara, colorPara);
            }
        }

        private void TmpPngToImage()
        {
            using (var stream = File.OpenRead("tmp.png"))
            {
                image = Image.FromStream(stream);
            }
        }

        private void PbLoadImage()
        {
            pictureBox1.Image = image;
        }

        private void PbLoadTmpPng()
        {
            TmpPngToImage();
            PbLoadImage();
        }

        public void ResetImageAndPb()
        {
            Chart1SaveToTmpPng();
            TmpPngToImage();
            PbLoadImage();
            saveNameWithTail = wrapper.SaveNameWithShift;           
        }

        public void Chart1SaveToTmpPng()
        {
            if (File.Exists("tmp.png"))
            {
                File.Delete("tmp.png");
            }

            chart1.SaveImage("tmp.png", ChartImageFormat.Png);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string saveName;

            if (rbtnBmp.Checked)
            {
                saveName = saveNameWithTail + ".bmp";
                image.Save(saveName, ImageFormat.Bmp);
            }
            else if (rbtnJpg.Checked)
            {
                saveName = saveNameWithTail + ".jpg";
                image.Save(saveName, ImageFormat.Jpeg);
            }
            else
            {
                saveName = saveNameWithTail + ".png";
                image.Save(saveName, ImageFormat.Png);
            }

            this.Text = saveName;
            RenewUI(label1, saveName + " is saved.");
        }

        public delegate void DelRenewUI(Control control, string msg);

        public void RenewUI(Control control, string msg)
        {
            if (this.InvokeRequired)
            {
                DelRenewUI del = new DelRenewUI(RenewUI);
                del(control, msg);
            }
            else
            {
                control.Text = msg;
            }
        }

        private void NconvertCmd(string args, string tail)
        {
            string srcPicName = GetSourceFile(); //tmp.png

            ProcessGo(args, srcPicName); //get tmp_1.png

            UpdateTmpPng();//replace tmp_1.png to tmp.png.

            PbLoadTmpPng();

            string finalPicName = AddTail(tail); //saveName add new tail.

            RenewUI(this, finalPicName);
            RenewUI(label1, finalPicName + " is updated.");
        }

        private void ProcessGo(string args, string picName)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"nconvert.exe")
            {
                WindowStyle = ProcessWindowStyle.Minimized
            };
            info.Arguments = args + picName;
            Process pro = Process.Start(info);
            pro.WaitForExit();
        }

        private void UpdateTmpPng()
        {
            if (File.Exists("tmp.png"))
            {
                File.Delete("tmp.png");
            }

            File.Move("tmp_1.png", "tmp.png");
            File.Delete("tmp_clear.png");
        }

        private string AddTail(string newTail)
        {
            //string destPicName = wrapper.DestFileName + ".png";
            //string finalPicName = wrapper.DestFileName + "_" + newTail + ".png";
            //File.Move(destPicName, finalPicName);
            //return finalPicName;

            saveNameWithTail = saveNameWithTail + "_" + newTail;

            return saveNameWithTail;
        }

        public string GetSourceFile()
        {
            string srcPicName = "tmp.png";
            if (!File.Exists(srcPicName))
            {
                Chart1SaveToTmpPng();
            }

            return srcPicName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetImageAndPb();

            RenewUI(this, "Reset");
            RenewUI(label1, "tmp.png is reset.");
        }

        private void textBoxOnlyForNums(object sender, KeyPressEventArgs e)
        {
            // 使用 Char.IsDigit 方法 : 指示指定的 Unicode 字元是否分類為十進位數字。
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9

            // Char.IsControl 方法 : 指示指定的 Unicode 字元是否分類為控制字元。
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            RenewUI(this, e.Location.ToString());
        }

        //nconvert -out png -resize 640 480 tmp.png
        private void btnResizePixel_Click(object sender, EventArgs e)
        {
            string resizePixelArgs = "-out png -resize " + txtResizePixelX.Text + " " + txtResizePixelY.Text+" ";
            string resizePixelTail = "Resize" + txtResizePixelX.Text + txtResizePixelY.Text;
            NconvertCmd(resizePixelArgs, resizePixelTail);
        }

        //nconvert -out png -resize 150% 150% tmp.png
        private void btnResizePercent_Click(object sender, EventArgs e)
        {
            string resizePercentArgs = "-out png -resize " + txtResizePercent.Text + "% " + txtResizePercent.Text + "% ";
            string resizePercentTail = "Resize" + txtResizePercent.Text;
            NconvertCmd(resizePercentArgs, resizePercentTail);
        }

        //nconvert -out png -rotate 90 tmp.png
        private void btnRotate45_Click(object sender, EventArgs e)
        {
            string rotateArgs = "-out png -rotate " + txtRotateAngle.Text + " ";
            string rotateTail = "Rotate" + txtRotateAngle.Text;
            NconvertCmd(rotateArgs, rotateTail);
        }

        //nconvert -out png -grey 256 tmp.png
        private void btnGrey_Click(object sender, EventArgs e)
        {
            string greyArgs = "-out png -grey " + cbGrey.SelectedItem.ToString() + " ";
            string greyTail = "Grey" + cbGrey.SelectedItem.ToString();
            NconvertCmd(greyArgs, greyTail);
        }

        //nconvert -out png -negate tmp.png
        private void btnNeagte_Click(object sender, EventArgs e)
        {
            string negateArgs = "-out png -negate ";
            string negateTail = "Negate";
            NconvertCmd(negateArgs, negateTail);
        }

        //nconvert -out png -crop x y w h tmp.png 
        private void btnCrop_Click(object sender, EventArgs e)
        {
            string cropArgs = "-out png -crop " + txtCropX.Text + " " + txtCropY.Text + " " + txtCropW.Text + " " + txtCropH.Text + " ";
            string cropTail = "Crop" + txtCropX.Text + txtCropY.Text + txtCropW.Text + txtCropH.Text;
            NconvertCmd(cropArgs, cropTail);
        }

        //nconvert -out png -brightness 100 tmp.png 
        private void btnBrightness_Click(object sender, EventArgs e)
        {
            string brightnessArgs = "-out png -brightness " + numBrightness.Text + " ";
            string brightnessTail = "Brightness" + numBrightness.Text;
            NconvertCmd(brightnessArgs, brightnessTail);
        }

        //nconvert -out png -xflip tmp.png 
        private void btnXflip_Click(object sender, EventArgs e)
        {
            string xflipArgs = "-out png -xflip ";
            string xflipTail = "Xflip";
            NconvertCmd(xflipArgs, xflipTail);
        }

        //nconvert -out png -yflip tmp.png
        private void btnYflip_Click(object sender, EventArgs e)
        {
            string yflipArgs = "-out png -yflip ";
            string yflipTail = "Yflip";
            NconvertCmd(yflipArgs, yflipTail);
        }
    }
}
