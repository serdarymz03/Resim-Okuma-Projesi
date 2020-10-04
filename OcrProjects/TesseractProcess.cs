using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace OcrProjects
{
    class TesseractProcess : IOcrProcess
    {
        public string ReadImage(Bitmap bitmap)
        {
            try
            {
                var ocr = new TesseractEngine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\tessdata", "tur");
                var result= ocr.Process(bitmap);
                return result.GetText();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
