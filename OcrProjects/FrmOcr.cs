using IronOcr;
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

namespace OcrProjects
{
    public partial class FrmOcr : Form
    {
        IOcrProcess ocrProcess;
        public FrmOcr()
        {
            InitializeComponent();
        }

        private void BtnReadImage_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult==DialogResult.OK)
            {
                AutoOcr ocr = new AutoOcr() { Language = IronOcr.Languages.Turkish.OcrLanguagePack };
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                PctBox.Image = bitmap;
                OcrResult result= ocr.Read(bitmap);

                RchText.Text = result.Text;
            }*/

            //ocrProcess = new IronOcrProcess();
            ocrProcess = new TesseractProcess();

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {               
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                PctBox.Image = bitmap;

                RchText.Text = ocrProcess.ReadImage(bitmap);
            }
        }
    }
}
