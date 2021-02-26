using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace fund_crawler1
{
    class MyTesseract
    {
        static TesseractEngine eng;
        static TesseractEngine numEng;
        public static void init()
        {
            eng = new TesseractEngine("tessdata", "chi_sim", EngineMode.TesseractOnly);//1078ms
            numEng = new TesseractEngine("tessdata", "eng", EngineMode.TesseractOnly);
        }
    }

}
