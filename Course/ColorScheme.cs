using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class ColorScheme
    {
        static int[] Form = new int[] { 172,194,156 };
        static int [] Button = new int[] { 244, 237, 182 };
        public static void ApplyColor(System.Windows.Forms.Form form)
        {
            form.BackColor = System.Drawing.Color.FromArgb(Form[0], Form[1], Form[2]);
            foreach(var element in form.Controls) 
                if(element is System.Windows.Forms.Button)
                    ((System.Windows.Forms.Button)element).BackColor = System.Drawing.Color.FromArgb(Button[0], Button[1], Button[2]);
        }
    }
}
