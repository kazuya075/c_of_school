using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace ConsoleApp2
{
    class Program 
    {
        static String[] nums;//リスト の要素をコピー用配列

        static void Main()
        {
            string line=""; //ファイル読み込み時用
            List<string> temp = new List<string>();//読み込んだファイルの中身を入れる用
            
            StreamReader sr = new StreamReader(@"C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\name.txt", Encoding.GetEncoding("Shift_JIS"));
            
             //ファイルから読み込んだ行を一旦リストに入れておく
            while(( sr.Peek()>-1)){ //ファイルの末尾に達するまでループ  
                line = sr.ReadLine();//行を読み込む
                temp.Add(line);//リストに追加
             }
           
            nums = temp.ToArray();//リスト の要素を新しい配列にコピー
                                    //toarrayでList<str> から str[] への変換
            Array.Sort(nums);//ソートする
            for (int i = 0;i < temp.Count();++i){//順に表示
                Console.WriteLine(nums[i] + "\r\n");
            }
            
        Console.ReadKey();
        
	    }
 

        }
    }

