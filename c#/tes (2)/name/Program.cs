using System;
using System.Text;
using System.IO;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    namespace Sample
    {
        class Sample
        {
            static string t; // ←　一時格納用
            static void Main()
            {
                StreamReader sr = new StreamReader(@"Z:\ダウンロード\test2\name\test.txt", Encoding.GetEncoding("Shift_JIS"));
                
                    t = sr.ReadLine();
                String[] numStrings = t.Split(' ');
                var numbers = new ArrayList();//arraylistに数値を入れる
              
                foreach (String str in numStrings)
                {
                    int num = int.Parse(str);
                    numbers.Add(num);
                }
                
                Console.WriteLine("正順 " + numbers);
                sr.Close();
                Console.ReadKey();
            }
        }
    }
}
/*
namespace ConsoleApp1
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello New World!");
            Console.WriteLine("終了するために何か適当にキーを押してね。");
            Console.ReadKey();

        }
    }
}*/

