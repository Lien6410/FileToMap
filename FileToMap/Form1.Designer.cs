namespace FileToMap
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOpenFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenTxtFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOpenFilePath
            // 
            this.txtOpenFilePath.Location = new System.Drawing.Point(93, 14);
            this.txtOpenFilePath.Name = "txtOpenFilePath";
            this.txtOpenFilePath.Size = new System.Drawing.Size(409, 22);
            this.txtOpenFilePath.TabIndex = 0;
            // 
            // btnOpenTxtFile
            // 
            this.btnOpenTxtFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenTxtFile.Name = "btnOpenTxtFile";
            this.btnOpenTxtFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTxtFile.TabIndex = 1;
            this.btnOpenTxtFile.Text = "OpenTxtFile";
            this.btnOpenTxtFile.UseVisualStyleBackColor = true;
            this.btnOpenTxtFile.Click += new System.EventHandler(this.btnOpenTxtFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 88);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenTxtFile);
            this.Controls.Add(this.txtOpenFilePath);
            this.Name = "Form1";
            this.Text = "FileToMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenTxtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtOpenFilePath;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

