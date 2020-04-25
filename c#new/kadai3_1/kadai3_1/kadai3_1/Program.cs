using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using static System.Console;

namespace kadai3_1
{
    class Program
    {
         static void WriteNumbers(IEnumerable<int> numbers)
          => WriteLine(string.Join(", ", numbers));
        static void Swap(ref int m, ref int n)
        {
          int work = m;
         m = n;
         n = work;
        }

        static IEnumerable<int> GetUniqRandomNumbers(int rangeBegin, int rangeEnd, int count,int w)
        {   
          // 指定された範囲の整数を格納できる配列を用意する
         int[] work = new int[rangeEnd - rangeBegin + 1];

           // 配列を初期化する
         for (int n = rangeBegin, i = 0; n <= rangeEnd; n++, i++)
          work[i] = n;

        // ランダムに取り出しては先頭から順に置いていく（count回繰り返す）
         var rnd = new Random();
         for (int resultPos = w; resultPos < count; resultPos++)
        {
           // （resultPosを含めて）resultPosの後ろからランダムに1つ選ぶ
          int nextResultPos = rnd.Next(resultPos, work.Length);

          // nextResultPosの値をresultPosと入れ替える
          Swap(ref work[resultPos], ref work[nextResultPos]);
         }

         return work.Take(count+15); // workの先頭からcount個を返す
          }


        

        static void Main(string[] args)
        {
               Console.WriteLine("1～52の整数から10個");
            WriteNumbers(GetUniqRandomNumbers(1, 52, 10,5));
              // 出力例： 38, 43, 41, 31, 14, 32, 48, 27, 52, 21


              ReadKey();
            
        }
        
    }
}
                //String str = s.Replace("\r", "");
                 //Console.WriteLine("[{0}]", string.Join(", ", s));
                 /*
            string line = ""; //ファイル読み込み時用
            List<string> temp = new List<string>();//読み込んだファイルの中身を入れる用

            StreamReader sr = new StreamReader(@"C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test3\\name\\name.txt", Encoding.GetEncoding("Shift_JIS"));

            //ファイルから読み込んだ行を一旦リストに入れておく
            while ((sr.Peek() > -1))
            { //ファイルの末尾に達するまでループ  
                line = sr.ReadLine();//行を読み込む
                string[] arr = line.Split(' ');//空白で区切ってstring型配列に
                temp.AddRange(arr);//リストに追加
            }
            

             foreach (string s in temp)//すべての要素を1回ずつ読み出す
             {
                Console.WriteLine("{0}", s);//表示
             }
           
            sr.Close();

            Console.ReadKey();*/
