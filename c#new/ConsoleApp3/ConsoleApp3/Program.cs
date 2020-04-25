using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace ConsoleApp3
{
    class Program
    {
       
      
        static void Main()
        {
            string[] nums;
            string[] first;
            string[][] name;
            string[]tmp;
            string line = "";//ファイルから読み込んだ行
             
            List<string> temp = new List<string>();//リスト

            StreamReader sr = new StreamReader(@"C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\name.txt", Encoding.GetEncoding("Shift_JIS"));

            //ファイルから読み込んだ行を一旦リストに入れておく
            while ((sr.Peek() > -1))
            {
                line = sr.ReadLine();
                temp.Add(line);
            }
            //name = new string[temp.Count()][];//多次元配列用意
           
            nums = temp.ToArray();//List の要素を新しい配列にコピー
        
            for(){
                tmp=nums[i*3];
                nums[i*3]=nums[j*3];
                nums[j*3]=tmp;

                 tmp=nums[i*3+1];
                nums[i*3+1]=nums[j*3+1];
                nums[j*3+1]=tmp;

                 tmp=nums[i*3+2];
                nums[i*3+2]=nums[j*3+2];
                nums[j*3+2]=tmp;

            }




            /*
             for (int i = 0;i < temp.Count();++i){//順に表示
                string[] s =  nums[i].Split(' ');//空白で区切ってstring型配列に
                for(int j = 0; j < 3; j++){
                    name[i][j] = s[j]; 
                }
             }

             foreach (var item in name.OrderBy(da => da[2]).ThenBy(da => da[1]))
            {
                Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);                
            }*/
             
            
            // Array.Sort(first,nums);

            for (int i = 0;i < temp.Count();++i){//順に表示
                Console.WriteLine(nums[i] + "\r\n");
            }
            
             Console.ReadKey();
        
        }
    }
}
 /*  for (int i = 0;i < temp.Count();++i){//順に表示//name3=name2.Cast<string>().ToArray();
                    name2[1,i]=name[i,2];
             }
             
     //static string[] first={"e", "c", "b","d"};
         // static string[,] name2;
        //static string[] name3; 
     //first[i]=s[j];  
     */