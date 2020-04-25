using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp6
{
    //順に引いたときのシャッフルは出来たが特定のカードを引いてのシャッフルが実装出来なかった
    
    public partial class Form1 : Form
    {
        public int push=0;//押した回数
        public int n = 0;//一度だけシャッフルするため
        tramp c;
       

        public Form1()
        {
            InitializeComponent();

            c = new tramp(this);//クラスのインスタンス生成時にForm1クラスのインスタンスを渡す

        }

        private void pull_card(object sender, EventArgs e)
        {
           
            if (push == 0 && n ==0){//最初に1度シャッフルする
                c.Draw(0);
                n++;
             }
            
            if(push<6){
                push++;
            }  
            if(push==1){
                c.Draw(1);//1枚目のカード表示
            }
            
            if(push==2){
                c.Draw(2);//2枚目のカード表示
            }

            if (push==3){
                c.Draw(3);//3枚目のカード表示
            }
            
            if(push==4){
                c.Draw(4);//4枚目のカード表示
            }

            if(push==5){
                c.Draw(5);//5枚目のカード表示
            }
            
        }


        private void return_card(object sender, EventArgs e)
        {
            if(push>0){//カードを非表示にして山札に戻している様にする
                push--;
            }  

            if(push==0){
                c.Blank(0);//1枚目のカード非表示
            }
            if(push==1){
                c.Blank(1);//2枚目のカード非表示
            }
            if(push==2){
                c.Blank(2);//3枚目のカード非表示
            }
            if(push==3){
                c.Blank(3);//4枚目のカード非表示
            }
            if(push==4){
                c.Blank(4);//5枚目のカード非表示
            }

        }

        private void shuffle_card(object sender, EventArgs e)
        {
            c.Shuffle(push,1);//カードを一部保存しシャッフル
        }

        private void reset(object sender, EventArgs e)
        {
            while(push>0){//押した回数を元に戻す
            push--;
            }
           
            c = new tramp(this);
            c.Shuffle(push,0);//シャッフル

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}



