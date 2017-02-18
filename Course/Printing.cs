using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace Course
{
    class Printing
    {
        Form form;
        string path;
        public Printing(Form f)
        {
            form = f;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            CaptureScreen();
            printDocument1.Print();
        }
        public Printing(Form f, string p)
        {
            form = f;
            path = p;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            CaptureScreen();
            SaveScreen();
        }
        Bitmap memoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private void CaptureScreen()        
        {
            Graphics myGraphics = form.CreateGraphics();
            Size s = new Size(form.Size.Width - 20, form.Size.Height -50);
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(form.Location.X+10, form.Location.Y+30, 0, 0, s);
        }
        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void SaveScreen()
        {
            memoryImage.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
