namespace FileToMap
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResizePixel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResizePercent = new System.Windows.Forms.Button();
            this.btnGrey = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtRotateAngle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnPng = new System.Windows.Forms.RadioButton();
            this.rbtnJpg = new System.Windows.Forms.RadioButton();
            this.rbtnBmp = new System.Windows.Forms.RadioButton();
            this.gbImageFormats = new System.Windows.Forms.GroupBox();
            this.txtResizePixelX = new System.Windows.Forms.TextBox();
            this.txtResizePixelY = new System.Windows.Forms.TextBox();
            this.txtResizePercent = new System.Windows.Forms.TextBox();
            this.cbGrey = new System.Windows.Forms.ComboBox();
            this.btnNeagte = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.txtCropX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCropY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCropW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCropH = new System.Windows.Forms.TextBox();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.numBrightness = new System.Windows.Forms.NumericUpDown();
            this.btnXflip = new System.Windows.Forms.Button();
            this.btnYflip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbImageFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(776, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(794, 43);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(216, 23);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 40);
            this.label1.TabIndex = 3;
            // 
            // btnResizePixel
            // 
            this.btnResizePixel.Location = new System.Drawing.Point(794, 141);
            this.btnResizePixel.Name = "btnResizePixel";
            this.btnResizePixel.Size = new System.Drawing.Size(216, 23);
            this.btnResizePixel.TabIndex = 4;
            this.btnResizePixel.Text = "像素縮放";
            this.btnResizePixel.UseVisualStyleBackColor = true;
            this.btnResizePixel.Click += new System.EventHandler(this.btnResizePixel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(794, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "------NConvert------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResizePercent
            // 
            this.btnResizePercent.Location = new System.Drawing.Point(794, 199);
            this.btnResizePercent.Name = "btnResizePercent";
            this.btnResizePercent.Size = new System.Drawing.Size(114, 23);
            this.btnResizePercent.TabIndex = 4;
            this.btnResizePercent.Text = "比例縮放";
            this.btnResizePercent.UseVisualStyleBackColor = true;
            this.btnResizePercent.Click += new System.EventHandler(this.btnResizePercent_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.Location = new System.Drawing.Point(794, 258);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(114, 23);
            this.btnGrey.TabIndex = 4;
            this.btnGrey.Text = "灰階";
            this.btnGrey.UseVisualStyleBackColor = true;
            this.btnGrey.Click += new System.EventHandler(this.btnGrey_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(794, 228);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(114, 23);
            this.btnRotate.TabIndex = 6;
            this.btnRotate.Text = "旋轉";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate45_Click);
            // 
            // txtRotateAngle
            // 
            this.txtRotateAngle.Location = new System.Drawing.Point(916, 230);
            this.txtRotateAngle.Name = "txtRotateAngle";
            this.txtRotateAngle.ShortcutsEnabled = false;
            this.txtRotateAngle.Size = new System.Drawing.Size(94, 22);
            this.txtRotateAngle.TabIndex = 7;
            this.txtRotateAngle.Text = "1";
            this.txtRotateAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRotateAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(794, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(216, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnPng
            // 
            this.rbtnPng.AutoSize = true;
            this.rbtnPng.Checked = true;
            this.rbtnPng.Location = new System.Drawing.Point(6, 17);
            this.rbtnPng.Name = "rbtnPng";
            this.rbtnPng.Size = new System.Drawing.Size(41, 16);
            this.rbtnPng.TabIndex = 10;
            this.rbtnPng.TabStop = true;
            this.rbtnPng.Text = "png";
            this.rbtnPng.UseVisualStyleBackColor = true;
            // 
            // rbtnJpg
            // 
            this.rbtnJpg.AutoSize = true;
            this.rbtnJpg.Location = new System.Drawing.Point(53, 17);
            this.rbtnJpg.Name = "rbtnJpg";
            this.rbtnJpg.Size = new System.Drawing.Size(38, 16);
            this.rbtnJpg.TabIndex = 11;
            this.rbtnJpg.Text = "jpg";
            this.rbtnJpg.UseVisualStyleBackColor = true;
            // 
            // rbtnBmp
            // 
            this.rbtnBmp.AutoSize = true;
            this.rbtnBmp.Location = new System.Drawing.Point(97, 17);
            this.rbtnBmp.Name = "rbtnBmp";
            this.rbtnBmp.Size = new System.Drawing.Size(44, 16);
            this.rbtnBmp.TabIndex = 12;
            this.rbtnBmp.Text = "bmp";
            this.rbtnBmp.UseVisualStyleBackColor = true;
            // 
            // gbImageFormats
            // 
            this.gbImageFormats.Controls.Add(this.rbtnPng);
            this.gbImageFormats.Controls.Add(this.rbtnBmp);
            this.gbImageFormats.Controls.Add(this.rbtnJpg);
            this.gbImageFormats.Location = new System.Drawing.Point(794, 72);
            this.gbImageFormats.Name = "gbImageFormats";
            this.gbImageFormats.Size = new System.Drawing.Size(216, 39);
            this.gbImageFormats.TabIndex = 13;
            this.gbImageFormats.TabStop = false;
            // 
            // txtResizePixelX
            // 
            this.txtResizePixelX.Location = new System.Drawing.Point(794, 170);
            this.txtResizePixelX.Name = "txtResizePixelX";
            this.txtResizePixelX.ShortcutsEnabled = false;
            this.txtResizePixelX.Size = new System.Drawing.Size(114, 22);
            this.txtResizePixelX.TabIndex = 7;
            this.txtResizePixelX.Text = "640";
            this.txtResizePixelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResizePixelX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // txtResizePixelY
            // 
            this.txtResizePixelY.Location = new System.Drawing.Point(916, 170);
            this.txtResizePixelY.Name = "txtResizePixelY";
            this.txtResizePixelY.ShortcutsEnabled = false;
            this.txtResizePixelY.Size = new System.Drawing.Size(94, 22);
            this.txtResizePixelY.TabIndex = 7;
            this.txtResizePixelY.Text = "480";
            this.txtResizePixelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResizePixelY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // txtResizePercent
            // 
            this.txtResizePercent.Location = new System.Drawing.Point(916, 200);
            this.txtResizePercent.Name = "txtResizePercent";
            this.txtResizePercent.ShortcutsEnabled = false;
            this.txtResizePercent.Size = new System.Drawing.Size(94, 22);
            this.txtResizePercent.TabIndex = 7;
            this.txtResizePercent.Text = "150";
            this.txtResizePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResizePercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // cbGrey
            // 
            this.cbGrey.FormattingEnabled = true;
            this.cbGrey.Items.AddRange(new object[] {
            "256",
            "128",
            "64",
            "32",
            "16",
            "8",
            "4"});
            this.cbGrey.Location = new System.Drawing.Point(916, 261);
            this.cbGrey.Name = "cbGrey";
            this.cbGrey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbGrey.Size = new System.Drawing.Size(94, 20);
            this.cbGrey.TabIndex = 14;
            this.cbGrey.Text = "256";
            // 
            // btnNeagte
            // 
            this.btnNeagte.Location = new System.Drawing.Point(794, 287);
            this.btnNeagte.Name = "btnNeagte";
            this.btnNeagte.Size = new System.Drawing.Size(215, 23);
            this.btnNeagte.TabIndex = 4;
            this.btnNeagte.Text = "負片";
            this.btnNeagte.UseVisualStyleBackColor = true;
            this.btnNeagte.Click += new System.EventHandler(this.btnNeagte_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(794, 316);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(216, 23);
            this.btnCrop.TabIndex = 15;
            this.btnCrop.Text = "裁減";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // txtCropX
            // 
            this.txtCropX.Location = new System.Drawing.Point(821, 345);
            this.txtCropX.Name = "txtCropX";
            this.txtCropX.ShortcutsEnabled = false;
            this.txtCropX.Size = new System.Drawing.Size(64, 22);
            this.txtCropX.TabIndex = 16;
            this.txtCropX.Text = "0";
            this.txtCropX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCropX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(793, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(917, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y";
            // 
            // txtCropY
            // 
            this.txtCropY.Location = new System.Drawing.Point(945, 345);
            this.txtCropY.Name = "txtCropY";
            this.txtCropY.ShortcutsEnabled = false;
            this.txtCropY.Size = new System.Drawing.Size(64, 22);
            this.txtCropY.TabIndex = 18;
            this.txtCropY.Text = "0";
            this.txtCropY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCropY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(793, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "W";
            // 
            // txtCropW
            // 
            this.txtCropW.Location = new System.Drawing.Point(821, 373);
            this.txtCropW.Name = "txtCropW";
            this.txtCropW.ShortcutsEnabled = false;
            this.txtCropW.Size = new System.Drawing.Size(64, 22);
            this.txtCropW.TabIndex = 20;
            this.txtCropW.Text = "640";
            this.txtCropW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCropW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(918, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "H";
            // 
            // txtCropH
            // 
            this.txtCropH.Location = new System.Drawing.Point(946, 373);
            this.txtCropH.Name = "txtCropH";
            this.txtCropH.ShortcutsEnabled = false;
            this.txtCropH.Size = new System.Drawing.Size(64, 22);
            this.txtCropH.TabIndex = 22;
            this.txtCropH.Text = "480";
            this.txtCropH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCropH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyForNums);
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(794, 401);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(114, 23);
            this.btnBrightness.TabIndex = 24;
            this.btnBrightness.Text = "亮度";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // numBrightness
            // 
            this.numBrightness.Location = new System.Drawing.Point(916, 401);
            this.numBrightness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numBrightness.Name = "numBrightness";
            this.numBrightness.Size = new System.Drawing.Size(94, 22);
            this.numBrightness.TabIndex = 25;
            this.numBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBrightness.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numBrightness.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // btnXflip
            // 
            this.btnXflip.Location = new System.Drawing.Point(794, 432);
            this.btnXflip.Name = "btnXflip";
            this.btnXflip.Size = new System.Drawing.Size(216, 23);
            this.btnXflip.TabIndex = 26;
            this.btnXflip.Text = "水平翻轉";
            this.btnXflip.UseVisualStyleBackColor = true;
            this.btnXflip.Click += new System.EventHandler(this.btnXflip_Click);
            // 
            // btnYflip
            // 
            this.btnYflip.Location = new System.Drawing.Point(794, 464);
            this.btnYflip.Name = "btnYflip";
            this.btnYflip.Size = new System.Drawing.Size(216, 23);
            this.btnYflip.TabIndex = 27;
            this.btnYflip.Text = "垂直翻轉";
            this.btnYflip.UseVisualStyleBackColor = true;
            this.btnYflip.Click += new System.EventHandler(this.btnYflip_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 496);
            this.Controls.Add(this.btnYflip);
            this.Controls.Add(this.btnXflip);
            this.Controls.Add(this.numBrightness);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCropH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCropW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCropY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCropX);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.cbGrey);
            this.Controls.Add(this.gbImageFormats);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResizePixelY);
            this.Controls.Add(this.txtResizePixelX);
            this.Controls.Add(this.txtResizePercent);
            this.Controls.Add(this.txtRotateAngle);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResizePercent);
            this.Controls.Add(this.btnNeagte);
            this.Controls.Add(this.btnGrey);
            this.Controls.Add(this.btnResizePixel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbImageFormats.ResumeLayout(false);
            this.gbImageFormats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResizePixel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResizePercent;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.TextBox txtRotateAngle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnPng;
        private System.Windows.Forms.RadioButton rbtnJpg;
        private System.Windows.Forms.RadioButton rbtnBmp;
        private System.Windows.Forms.GroupBox gbImageFormats;
        private System.Windows.Forms.TextBox txtResizePixelX;
        private System.Windows.Forms.TextBox txtResizePixelY;
        private System.Windows.Forms.TextBox txtResizePercent;
        private System.Windows.Forms.ComboBox cbGrey;
        private System.Windows.Forms.Button btnNeagte;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.TextBox txtCropX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCropY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCropW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCropH;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.NumericUpDown numBrightness;
        private System.Windows.Forms.Button btnXflip;
        private System.Windows.Forms.Button btnYflip;
    }
}