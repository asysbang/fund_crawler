using OpenCvSharp.Extensions;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using System;

namespace fund_crawler1
{
    class MyOpencv
    {

        public static void screencap()
        {
            int nWidth, nHeight;    //显示器宽度、高度
            //获取显示器尺寸
            nWidth = Screen.PrimaryScreen.Bounds.Width;
            nHeight = Screen.PrimaryScreen.Bounds.Height;
            Bitmap bit = new Bitmap(nWidth, nHeight);   //实例化一个图像，尺寸大小为主显示器尺寸
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(nWidth, nHeight));
            bit.Save("screen.png");
            Mat x = BitmapConverter.ToMat(bit);
            //Cv2.ImWrite("area.png", x);
        }
        //分割图像得到每组位置
        public static void spliteMat()
        {
            Mat mat = new Mat("001.png");
            Console.WriteLine("======={0}",mat.Rows);
            Mat subMat = mat.SubMat(620, 992,440, 1450);
            Cv2.ImWrite("area.png", subMat);

        }
    }
}
