using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp5
{//クラス名を変更しようとするとエラー表示のためcoincaseに変更できず
    public partial class Form1 : Form
    {
        static int sum=0;//総額計算用
        static int coin500=0;//500円の硬貨の枚数計算用
        static int coin100=0;//100
        static int coin50=0;//50
        static int coin10=0;//10
        static int coin5=0;//5
        static int coin1=0;//1


        public Form1()
        {
            InitializeComponent();
            GetCount();//開始時の各枚数、総額表示
            GetAmount();//

        }

        private void AddCoin(int a)//追加
        {
            if(a==500){
              coin500 ++;//500円追加
            }
            else if(a==100){
              coin100 ++;//100円追加
            }
            else if(a==50){
              coin50 ++;//50
            }
            else if(a==10){
              coin10 ++;//10
            }
            else if(a==5){
              coin5 ++;//5
            }
            else if(a==1){
              coin1 ++;//1
            }
            
        }

        private void ReduseCoin(int a)//引き出し        
        {

            if(a==500&&coin500>0){//&&で0から引き出せなくしている
                coin500 --;//500円引き出し         
            }
            else if(a==100&&coin100>0){
                coin100 --;//100円引き出し
            }
            else if(a==50&&coin50>0){
                coin50 --;//50
            }
            else if(a==10&&coin10>0){
                coin10 --;//10
            }
            else if(a==5&&coin5>0){
                coin5 --;//5
            }
            else if(a==1&&coin1>0){
                coin1 --;//1
            }

        }

        private void GetCount()//指定した硬貨が何枚入っているか
        {
                textBox2.Text = coin500.ToString();//textboxに500円の枚数表示
                textBox3.Text = coin100.ToString();//textboxに100円の枚数表示
                textBox5.Text = coin50.ToString();//textboxに50円の枚数表示
                textBox4.Text = coin10.ToString();//textboxに10円の枚数表示
                textBox7.Text = coin5.ToString();//textboxに5円の枚数表示
                textBox6.Text = coin1.ToString();//textboxに1円の枚数表示

        }

        private void GetAmount()//総額表示
        {//各硬貨の和を出す
            sum = coin500 * 500 + coin100 * 100 + coin50 * 50 + coin10 * 10 + coin5 * 5 + coin1;
            textBox1.Text = sum.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddCoin(500);//500円追加
            GetCount();//計算された各枚数表示
            GetAmount();//計算された総額表示
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReduseCoin(500);//500円引き出し
            GetCount();//計算された各枚数表示
            GetAmount();//計算された総額表示
        }

        //以下、各硬貨で同じように処理


        private void button4_Click(object sender, EventArgs e)
        {
            AddCoin(100);
            GetCount();
            GetAmount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReduseCoin(100);
            GetCount();
            GetAmount();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            AddCoin(50);
            GetCount();
            GetAmount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReduseCoin(50);
            GetCount();
            GetAmount();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddCoin(10);
            GetCount();
            GetAmount();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReduseCoin(10);
            GetCount();
            GetAmount();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddCoin(5);
            GetCount();
            GetAmount();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReduseCoin(5);
            GetCount();
            GetAmount();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddCoin(1);
            GetCount();
            GetAmount();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReduseCoin(1);
            GetCount();
            GetAmount();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 //string s = sum.ToString();
            //textBox1.Text = s;
            //textBox2.Text = coin500.ToString();
            //textBox1.Text = sum.ToString();
                        /*
            //初期0表示用    
            textBox2.Text = coin500.ToString();//500円の桁 ToStringでstringにして textBox2.Textに入れる      
            textBox3.Text = coin100.ToString();//100円の桁 ToStringでstringにして textBox3.Textに入れる
            textBox5.Text = coin50.ToString();//50円の桁 ToStringでstringにして textBox5.Textに入れる        
            textBox4.Text = coin10.ToString();//10円の桁 ToStringでstringにして textBox4.Textに入れる
            textBox7.Text = coin5.ToString();//5円の桁 ToStringでstringにして textBox7.Textに入れる 
            textBox6.Text = coin1.ToString();//1円の桁 ToStringでstringにして textBox6.Textに入れる
            */