using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    using System.IO;
    using System.Text;

    namespace Sample
    {
        class Sample
        {
            static void Main()
            {
                StreamReader sr = new StreamReader(@"E:\samurai.txt", Encoding.GetEncoding("Shift_JIS"));

                while (sr.Peek() != -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();

                Console.ReadKey();
            }
        }
    }
}/*
class Program
{
    static string t; // ←　一時格納用
    static void Main()
    {
        StreamReader sr = new StreamReader(@"C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\test.txt", Encoding.GetEncoding("Shift_JIS"));

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
    }*/
