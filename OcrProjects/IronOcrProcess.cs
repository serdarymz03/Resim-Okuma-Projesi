using IronOcr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrProjects
{
    class IronOcrProcess : IOcrProcess
    {
        public string ReadImage(Bitmap bitmap)
        {
            try
            {
                AutoOcr ocr = new AutoOcr() { Language = IronOcr.Languages.Turkish.OcrLanguagePack };
                OcrResult result = ocr.Read(bitmap);
                return result.Text;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
