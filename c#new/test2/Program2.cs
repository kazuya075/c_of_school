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
}
