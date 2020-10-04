namespace OcrProjects
{
    partial class FrmOcr
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PctBox = new System.Windows.Forms.PictureBox();
            this.BtnReadImage = new System.Windows.Forms.Button();
            this.RchText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PctBox
            // 
            this.PctBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctBox.Location = new System.Drawing.Point(12, 12);
            this.PctBox.Name = "PctBox";
            this.PctBox.Size = new System.Drawing.Size(501, 234);
            this.PctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox.TabIndex = 0;
            this.PctBox.TabStop = false;
            // 
            // BtnReadImage
            // 
            this.BtnReadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnReadImage.Location = new System.Drawing.Point(137, 261);
            this.BtnReadImage.Name = "BtnReadImage";
            this.BtnReadImage.Size = new System.Drawing.Size(254, 46);
            this.BtnReadImage.TabIndex = 1;
            this.BtnReadImage.Text = "Resim Seç ve Oku";
            this.BtnReadImage.UseVisualStyleBackColor = true;
            this.BtnReadImage.Click += new System.EventHandler(this.BtnReadImage_Click);
            // 
            // RchText
            // 
            this.RchText.Location = new System.Drawing.Point(12, 325);
            this.RchText.Name = "RchText";
            this.RchText.Size = new System.Drawing.Size(501, 141);
            this.RchText.TabIndex = 2;
            this.RchText.Text = "";
            // 
            // FrmOcr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 478);
            this.Controls.Add(this.RchText);
            this.Controls.Add(this.BtnReadImage);
            this.Controls.Add(this.PctBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOcr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocr İşlemi";
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PctBox;
        private System.Windows.Forms.Button BtnReadImage;
        private System.Windows.Forms.RichTextBox RchText;
    }
}