using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1_p.71~p.72 練習:");
            Console.WriteLine();
            
            //學生姓名
            string[] student = new string[] {"Jack","Mary","Tom","Grace","Alice"};
            //成績 {電腦概論,程式設計,動畫設計}
            int[,] score = new int[,] { { 80,75,60},{65,67,62},{100,93,91},{98,25,50},{83,82,87}};

            while (true)
            {
                Console.Write("輸入座號(1-5)：");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 5)
                {
                    Console.WriteLine("座號超出範圍");
                }
                else
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("1. 姓名:" + student[num - 1]);
                        Console.WriteLine("2. 電腦概論:" + score[num - 1, 0]);
                        Console.WriteLine("3. 程式設計:" + score[num - 1, 1]);
                        Console.WriteLine("4. 動畫設計:" + score[num - 1, 2]);
                    }
                    break;
                }
            }

            Console.ReadKey();
         
        }
            Console.WriteLine("練習2.輸入N, 印出:");
            Console.Write("Input num:");
            int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("num:"+num);
            for(int i=1;i<=num;i++){
              Console.WriteLine(num+"*"+i+"="+(num*i));
            }
          }
  
          //練習3.用兩個迴圈 做出九九乘法表 function
          static void t3(){
            Console.Write("練習3.用兩個迴圈 做出九九乘法表：");
            for(int i=1;i<10;i++){
              Console.WriteLine();
              for(int j=1;j<10;j++){
                Console.WriteLine(i+"*"+j+"="+(i*j));
              }
            }  
          }
            Console.WriteLine("練習2.輸入N, 印出:");
            Console.Write("Input num:");
            int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("num:"+num);
            for(int i=1;i<=num;i++){
              Console.WriteLine(num+"*"+i+"="+(num*i));
            }
          }
  
          //練習3.用兩個迴圈 做出九九乘法表 function
          static void t3(){
            Console.Write("練習3.用兩個迴圈 做出九九乘法表：");
            for(int i=1;i<10;i++){
              Console.WriteLine();
              for(int j=1;j<10;j++){
                Console.WriteLine(i+"*"+j+"="+(i*j));
              }
            }  
          }
    }
}