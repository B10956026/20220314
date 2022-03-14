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
            //string[] title = new string[] { "座號", "姓名", "電腦概論","程式設計","動畫設計"};
            string[,] student = new string[,] { { "1", "Jack" },{ "2", "Mary" },{ "3", "Tom" },{ "4", "Grace" },{ "5", "Alice" } };
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
                        Console.WriteLine("1. 姓名:" + student[num - 1, 1]);
                        Console.WriteLine("2. 電腦概論:" + score[num - 1, 0]);
                        Console.WriteLine("3. 程式設計:" + score[num - 1, 1]);
                        Console.WriteLine("4. 動畫設計:" + score[num - 1, 2]);
                    }
                    break;
                }
            }
         
        }
    }
}