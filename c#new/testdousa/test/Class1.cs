using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
  
    public class Class1
    {
        
        public Form1 form;
        public Class1(Form1 form1)
        {
            form = form1; // 渡されたForm1をローカル変数へ
            Huga();
        }
        private void Huga()
        {
            form.AddListItem("Line:1");
            Image imgc1 = Image.FromFile(@"C:\Users\fmv\Desktop\cardImages100x150\z01.png");
            form.pictureBox1.Image = imgc1;
            form.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }



    }
}
