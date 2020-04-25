using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formskadai3_2
{
    public partial class Form1 : Form
    {
        static string inputtext2;//名前などのtextBoxのコピー用
        static string inputtext3;
        static string inputtext4;
        static int inputtext;//stringからint用

        static string inputtext5;//検索のtextBoxのコピー用
        static int inputtext6;//stringからint用
        
        
        
        Dictionary<int, string> myTable = new Dictionary<int, string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputtext2 = textBox2.Text;//textBox内のコピー
            inputtext3 = textBox3.Text;
            inputtext4 = textBox4.Text;

            inputtext = int.Parse(inputtext4);//学籍番号をintに

            myTable.Add(inputtext, inputtext2 + inputtext3);//Dictionaryに追加
           

            textBox2.ResetText();//textBox内の削除
            textBox3.ResetText();
            textBox4.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {//例外処理
            inputtext5 = textBox5.Text;//検索のtextBoxの番号コピー
            inputtext6 = int.Parse(inputtext5);//stringからint
            
            textBox1.Text = myTable[inputtext6];//textBox1に表示
            textBox5.ResetText();//textBox内の削除
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// string s = String.Join("\r\n", myTable);//改行して１つにまとめる