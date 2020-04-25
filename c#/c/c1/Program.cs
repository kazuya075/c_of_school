using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp1
{
class Sample
{
    static void Main()
    {
        using (System.IO.StreamReader file = new System.IO.StreamReader(@"Z:\ダウンロード\test2\name\name.txt", System.Text.Encoding.UTF-8))
        {
            string line = "";
            List<string> list = new List<string>();         //空のListを作成する

            // test.txtを1行ずつ読み込んでいき、末端(何もない行)までwhile文で繰り返す
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }
            /*MessageBox.Show(list[0]);  // 2015/09/25 15:12:09 あああああ
            MessageBox.Show(list[1]); // 2015/09/26 09:23:11 いいいいい
            MessageBox.Show(list[2]);  // 2015/09/29 19:09:00 ううううう
            */
            // 配列の長さがわからない場合はforeachで回す
            foreach (var item in list)
            {
                MessageBox.Show(item);
            }
        }
    }
}

  /* class Sample
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"Z:\ダウンロード\test2\name\name.txt", Encoding.GetEncoding("Shift_JIS"));
 
            while (sr.Peek() != -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
 
            sr.Close();
 
            Console.ReadKey();
        }
    }*/
}
