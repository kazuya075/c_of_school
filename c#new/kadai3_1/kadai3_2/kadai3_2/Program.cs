using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai3_2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            // 入力を促すメッセージの表示
            Console.Write("入力人数は？　　: ");
            int num = int.Parse(Console.ReadLine());//int型


            int[] s_num = new int[num];//各学籍番号を保持
            string[] name_c = new string[num];//各名前(漢字)を保持
            string[] name_k = new string[num];//各名前(かな)を保持

            int[] number = new int[1];//知りたい学籍番号を保持

            var myTable = new Dictionary<int, string>();

            for (int i = 0;i<num;i++) {
                 // 入力を促すメッセージの表示
                Console.Write("学籍番号は？　　: ");
                 s_num[i] = int.Parse(Console.ReadLine());//int型

                Console.Write("氏名は？　: ");
                 name_c[i] = Console.ReadLine();//string型

                Console.Write("読み仮名は？ : ");
                 name_k[i] = Console.ReadLine();//string型

                myTable[s_num[i]] = name_c[i]+ name_k[i];//番号ごとにDictionaryに入れる
              

            }
           
            Console.Write("知りたい学籍番号は？　　: ");
            number[0] = int.Parse(Console.ReadLine());// 入力を促すメッセージの表示

            try//例外処理
            {
                Console.WriteLine("[{0}:{1}]", number[0], myTable[number[0]]);//表示
            }
            catch (Exception)
            {
                Console.WriteLine("存在しない値です");//表示
            }
            
            Console.ReadKey();
            
        }
    }
}

//  Console.WriteLine("[{0}]", myTable[s_num[i]]);
//Console.WriteLine("[{0}]", number[0]);