using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//https://algorithm.joho.info/programming/csharp/array-foreach-cs/
//https://www.sejuku.net/blog/44242
namespace ConsoleApp1
{
    class Sample
    {
        //static string t;//
        static void Main()
        {
            StreamReader sr = new StreamReader(@"C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\test.txt", Encoding.GetEncoding("Shift_JIS"));
            string t = sr.ReadLine(); //

            string[] arr = t.Split(' ');//空白で区切ってstring型配列に
            int[] intArray = new int[arr.Length];//int型配列をarrの要素分用意

            for (int i = 0; i < intArray.Length; i++)
            {//intArrayの要素分繰り返し
                intArray[i] = int.Parse(arr[i]);
            }//arr内の数値をint型に変換して配列に

            Console.WriteLine("正順 [{0}]", string.Join(", ", intArray));// 配列内のデータをすべてカンマ区切りで連結する
            Array.Reverse(intArray);//sort
            Console.WriteLine("逆順 [{0}]", string.Join(", ", intArray));
            Array.Sort(intArray);//sort
            Console.WriteLine("昇順 [{0}]", string.Join(", ", intArray));
            Array.Reverse(intArray);//sort
            Console.WriteLine("降順 [{0}]", string.Join(", ", intArray));

            sr.Close();

            Console.ReadKey();
        }

    }
}
