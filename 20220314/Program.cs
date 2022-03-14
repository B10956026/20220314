using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220314
{
    class Program
    {
        public static void Main (string[] args) {
            Console.WriteLine("C#1 p.51 練習：");

            Console.WriteLine();
    
            t1(); //呼叫 練習1 function
    
            Console.WriteLine();
    
            t2(); //呼叫 練習2 function
    
            Console.WriteLine();
    
            t3(); //呼叫 練習3 function

            Console.ReadKey();
        }

          //練習1.輸入N, 印出 function
          static void t1(){
            Console.WriteLine("練習1.輸入N, 印出:");
            Console.Write("Input num:");
            int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("num:"+num);
            for(int i=0;i<num;i++){
              for(int j=0;j<=i;j++){
                Console.Write("*");
              }
              Console.WriteLine();
            }
          }

          //練習2.輸入N, 印出 function
            static void t2(){
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
