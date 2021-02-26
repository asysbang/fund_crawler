using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fund_crawler1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Thread d = new Thread(loxxxx);
            d.Start();
        }

        private void loxxxx()
        {
            Console.WriteLine("========loxxxx=");
            Thread.Sleep(2000);
            //MyMouse.tap(333, 828);
            //Thread.Sleep(3000);
            MyOpencv.screencap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MyOpencv.screencap();
            
            MyTesseract.init();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyOpencv.spliteMat();
        }
    }
}
