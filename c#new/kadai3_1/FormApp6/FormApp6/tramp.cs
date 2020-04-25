using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp6
{
    public class tramp
    {
        public int[] tester;//dataAの値を変換した物を格納
        public int[] tester2=new int[5];//トランプの値保存用
        public IEnumerable<int> dataA;//整数から重複なしに選んだ値を格納
        public Form1 form;//Form1のインスタンスをtrampクラスに渡す
        

        public tramp(Form1 form1)
        {
            form = form1;
            Place();
        }

        //最初に全体の描画用メソッド
        private void Place()
        {
            form.pictureBox1.Image = null;//pictureBox1を空白に
            form.pictureBox2.Image = null;//pictureBox2を空白に
            form.pictureBox3.Image = null;//以下略
            form.pictureBox4.Image = null;
            form.pictureBox5.Image = null;
            Image imgc1 = Image.FromFile(@"C:\Users\fmv\Desktop\cardImages100x150\z01.png");//山札の画像表示
            form.pictureBox6.Image = imgc1;
            form.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;//pictureBox1に画像の大きさを合わせている
        }

        //戻すを押した際にpictureboxを空白にする用メソッド
        public void Blank(int p)
        {
            if (p == 0)
            {
                form.pictureBox1.Image = null;//pictureBox1を空白に
            }
            if (p == 1)
            {
                form.pictureBox2.Image = null;//pictureBox2を空白に
            }
            if (p == 2)
            {
                form.pictureBox3.Image = null;//以下略
            }
            if (p == 3)
            {
                form.pictureBox4.Image = null;
            }
            if (p == 4)
            {
                form.pictureBox5.Image = null;
            }
            
        }

        //引くを押した際にpictureboxに表示するメソッド
        public void Draw(int d)
        {
            if (d == 0)
            {//1～52の整数から重複なしに5個選び返す
                //GetUniqRandomNumbersでシャッフルしている
                dataA = GetUniqRandomNumbers(1, 52, 5);
                tester = dataA.ToArray();//型変換後配列に
            }

            if (d == 1)
            { //ImageRead()の()の中の数値によって表示される絵柄が違う
                Image imgc1 = Image.FromFile(ImageRead(tester[0]));//5個選んだ数値から表示する画像が選ばれる      
                form.pictureBox1.Image = imgc1; //pictureBox内に表示
                form.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//pictureBox1に画像の大きさを合わせている
            }

            if (d == 2)
            {
                Image imgc2 = Image.FromFile(ImageRead(tester[1]));
                form.pictureBox2.Image = imgc2;
                form.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (d == 3)
            {
                Image imgc3 = Image.FromFile(ImageRead(tester[2]));
                form.pictureBox3.Image = imgc3;
                form.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            if (d == 4)
            {
                Image imgc4 = Image.FromFile(ImageRead(tester[3]));
                form.pictureBox4.Image = imgc4;
                form.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            if (d == 5)
            {
                Image imgc5 = Image.FromFile(ImageRead(tester[4]));
                form.pictureBox5.Image = imgc5;
                form.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }
        //シャッフル用メソッド
        public void Shuffle(int p,int r)
        {
            if (r == 1)
            {//trueの意味を込め1で配列保存
                
                tester2[0] = tester[0];//カードを一部だけシャッフルしたいときのために
                tester2[1] = tester[1];//一度別の配列に保存
                tester2[2] = tester[2];
                tester2[3] = tester[3];
                tester2[4] = tester[4];
            }

            dataA = GetUniqRandomNumbers(1, 52, 5); //シャッフルする
            tester = dataA.ToArray();//型変換後配列に
           

            if (p == 4) {//カードを1枚シャッフルの時
                //まず配列の中で tester2[0]と一致するものがあったら
                //山札の一番上に当たるtester[0] と交換
                //{2,4,5,9,7,3,8･･･}がシャッフル前だったとして
                //上記date･･･でシャッフルされた後の配列
                //{1,11,6,9,8,3,2･･･}を
                //{2,11,6,9,8,3,1･･･}のようにしている
                int ret = Array.IndexOf(tester, tester2[0]) + 1;//配列のret番目が一致していると
                tester[0] = tester[ret];                        //Array.IndexOfで調べられる   
                tester[ret] = tester2[0];
                

                int ret1 = Array.IndexOf(tester, tester2[1]) + 1;//以下同様に
                tester[1] = tester[ret1];
                tester[ret1] = tester2[1];
                int ret2 = Array.IndexOf(tester, tester2[0]) + 1;
                tester[2] = tester[ret2];
                tester[ret2] = tester2[2];
                int ret3 = Array.IndexOf(tester, tester2[0]) + 1;
                tester[3] = tester[ret3];
                tester[ret3] = tester2[3];
                
            }
            if (p == 3)
            {//カードを2枚シャッフルの時
                int ret = Array.IndexOf(tester, tester2[0])+1;
                tester[0] = tester[ret];
                tester[ret] = tester2[0];
                int ret1 = Array.IndexOf(tester, tester2[1]) + 1;
                tester[1] = tester[ret1];
                tester[ret1] = tester2[1];
                int ret2 = Array.IndexOf(tester, tester2[0]) + 1;
                tester[2] = tester[ret2];
                tester[ret2] = tester2[2];
                
            }
            if (p == 2)
            {//カードを3枚シャッフルの時
                int ret = Array.IndexOf(tester, tester2[0]) + 1;
                tester[0] = tester[ret];
                tester[ret] = tester2[0];
                int ret1 = Array.IndexOf(tester, tester2[1]) + 1;
                tester[1] = tester[ret1];
                tester[ret1] = tester2[1];
                
            }
            if (p == 1)
            {//カードを4枚シャッフルの時
                int ret = Array.IndexOf(tester, tester2[0]) + 1;
                tester[0] = tester[ret];
                tester[ret] = tester2[0];
                
            }

        }

            //シャッフル処理に使用
            public void Swap(ref int m, ref int n)
        {
            int work = m;
            m = n;
            n = work;
        }


        //IEnumerable foreachでコレクション処理できる

        //http://www.atmarkit.co.jp/ait/articles/1710/11/news019.html
        //ダステンフェルドのアルゴリズムを使って指定した整数の範囲で重複しない乱数を生成するメソッド
        //ダステンフェルドのアルゴリズムは、配列中のランダムな位置を選び、
        //その値を先頭から（あるいは、末尾から）再配置していくというもの
        //シャッフルにそのまま流用
        public IEnumerable<int> GetUniqRandomNumbers(int rangeBegin, int rangeEnd, int count)
        {
            // 指定された範囲の整数を格納できる配列を用意する
            int[] work = new int[rangeEnd - rangeBegin + 1];
            
            // 配列を初期化する
            for (int n = rangeBegin, i = 0; n <= rangeEnd; n++, i++)
                work[i] = n;

            // ランダムに取り出しては先頭から順に置いていく（count回繰り返す）
            var rnd = new Random();
            for (int resultPos = 0; resultPos < count; resultPos++)
            {
                // （resultPosを含めて）resultPosの後ろからランダムに1つ選ぶ
                int nextResultPos = rnd.Next(resultPos, work.Length);

                // nextResultPosの値をresultPosと入れ替える
                Swap(ref work[resultPos], ref work[nextResultPos]);
            }

            return work.Take(count); // workの先頭からcount個を返す
        }



        //png詠み込み用の文用意メソッド

        //画像を読み込む際Image img = Image.FromFile(@"C:\Users\fmv\Desktop\cardImages100x150\c01.png");
        //とする所を@"C:\Users\fmv\Desktop\cardImages100x150\c01.png"の部分をstring文としておく
        //これをのちに配列に入れたカード番号と対応させて絵柄を表示する
        //例えばImage imgc1 = Image.FromFile(ImageRead(tester[0]))のときは
        //tester[0]内のカード番号とaが同じ値の絵柄を表示する
        public string ImageRead(int a)
        {
            if (a == 1)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c01.png";//c01.png読み込みに使用
                return filename;

            }
            else if (a == 2)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c02.png";//c02.png読み込みに使用
                return filename;

            }
            else if (a == 3)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c03.png";//以下c03.png,c04.pngと続く
                return filename;

            }
            else if (a == 4)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c04.png";
                return filename;

            }
            else if (a == 5)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c05.png";
                return filename;

            }
            else if (a == 6)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c06.png";
                return filename;

            }
            else if (a == 7)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c07.png";
                return filename;
            }
            else if (a == 8)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c08.png";
                return filename;
            }
            else if (a == 9)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c09.png";
                return filename;
            }
            
            else if (a == 10)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c10.png";
                return filename;
            }
            else if (a == 11)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c11.png";
                return filename;
            }
            else if (a == 12)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c12.png";
                return filename;
            }
            else if (a == 13)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\c13.png";
                return filename;
            }
            else if (a == 14)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d01.png";
                return filename;
            }
            else if (a == 15)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d02.png";
                return filename;

            }
            else if (a == 16)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d03.png";
                return filename;
            }
            else if (a == 17)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d04.png";
                return filename;
            }
            else if (a == 18)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d05.png";
                return filename;
            }
            else if (a == 19)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d06.png";
                return filename;
            }
            
            else if (a == 20)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d07.png";
                return filename;
            }
            else if (a == 21)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d08.png";
                return filename;
            }
            else if (a == 22)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d09.png";
                return filename;
            }
            else if (a == 23)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d10.png";
                return filename;
            }
            else if (a == 24)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d11.png";
                return filename;
            }
            else if (a == 25)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d12.png";
                return filename;
            }
            else if (a == 26)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\d13.png";
                return filename;
            }
            else if (a == 27)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h01.png";
                return filename;
            }
            else if (a == 28)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h02.png";
                return filename;
            }
            else if (a == 29)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h03.png";
                return filename;
            }
            
            else if (a == 30)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h04.png";
                return filename;
            }
            else if (a == 31)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h05.png";
                return filename;
            }
            else if (a == 32)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h06.png";
                return filename;
            }
            else if (a == 33)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h07.png";
                return filename;
            }
            else if (a == 34)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h08.png";
                return filename;
            }
            else if (a == 35)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h09.png";
                return filename;
            }
            else if (a == 36)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h10.png";
                return filename;
            }
            else if (a == 37)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h11.png";
                return filename;
            }
            else if (a == 38)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h12.png";
                return filename;
            }
            else if (a == 39)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\h13.png";
                return filename;
            }

            else if (a == 40)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s01.png";
                return filename;
            }
            else if (a == 41)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s02.png";
                return filename;
            }
            else if (a == 42)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s03.png";
                return filename;
            }
            else if (a == 43)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s04.png";
                return filename;
            }
            else if (a == 44)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s05.png";
                return filename;
            }
            else if (a == 45)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s06.png";
                return filename;
            }
            else if (a == 46)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s07.png";
                return filename;
            }
            else if (a == 47)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s08.png";
                return filename;
            }
            else if (a == 48)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s09.png";
                return filename;
            }
            else if (a == 49)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s10.png";
                return filename;
            }

            else if (a == 50)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s11.png";
                return filename;
            }
            else if (a == 51)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s12.png";
                return filename;
            }
            else if (a == 52)
            {
                string filename = @"C:\Users\fmv\Desktop\cardImages100x150\s13.png";
                return filename;
            }
            
            string filename2 = @"C:\Users\fmv\Desktop\cardImages100x150\z01.png";
            return filename2;

        }
        
    }
}

