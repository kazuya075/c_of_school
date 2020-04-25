using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            //Console.ReadLine();

            string[] data2 = new string[] { "2", "bb", "4" };
            string[] data1 = new string[] { "1", "aa", "4" };
            string[] data3 = new string[] { "3", "cc", "3" };
            string[] data4 = new string[] { "3", "dd", "4" };
            string[] data5 = new string[] { "3", "ee", "1" };

            string[][] data_all = new string[5][];
            data_all[0] = data1;
            data_all[1] = data2;
            data_all[2] = data3;
            data_all[3] = data4;
            data_all[4] = data5;

            foreach (var item in data_all.OrderBy(da => da[2]).ThenBy(da => da[1]))
            {
                Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);
            }

            Console.ReadLine();


        }
    }
}
