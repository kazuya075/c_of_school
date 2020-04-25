using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace kadai3_1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}
                //String str = s.Replace("\r", "");
                 //Console.WriteLine("[{0}]", string.Join(", ", s));