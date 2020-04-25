using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formkadai3_1
{
    public partial class Form1 : Form
    {
        
        static string inputtext2;//textBox内のコピー用
        static string inputtext3;
        static string inputtext4;
        List<string> temp = new List<string>();//読み込んだtextBoxの中身を入れる用リスト


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            inputtext2 = textBox2.Text;//textBox内のコピー
            inputtext3 = textBox3.Text;
            inputtext4 = textBox4.Text;

            temp.Add(inputtext2);//リストに追加
            temp.Add(inputtext3);
            temp.Add(inputtext4);

            textBox2.ResetText();//textBox内の削除
            textBox3.ResetText();
            textBox4.ResetText();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = String.Join("\r\n", temp);//改行して１つにまとめる
            textBox1.Text = s;//textBox1に表示

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}



 //"\r\n"+System.Environment.NewLine
             //   label5.Text = 1;
           /* foreach (string s in temp)
            {
                textBox1.Text = s;
                //Console.WriteLine("{0}", s);
            }*/
           
