using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str" ,"alex", "moh" };
            string[] arr3 = { "the", "fox" ,"over" , "lazy", "dog" };
            /////////////////////////////////////////////////////////////
            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            Console.WriteLine(Array.IndexOf(fruits,"Tomato"));
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            ///////////////////////////////////////////////////////////////////////
            string[] food = { "apple", "banana", "potato", "tomato", "romaro" };

            foreach(string f in food)
            {
                Console.WriteLine(f);
            }

            string[] sport = { "football", "basketball", "volyball" };

            foreach(string s in sport)
            {
                Console.WriteLine(s);
            }

            string[] movie = { "the last kingdome", "the best of me", "BB", "prison break" };

            foreach (string m in movie)
            {
                Console.WriteLine(m);
            }
            //////////////////////////////////////////////////////////////
            Console.WriteLine("inter three numbers:");
           string z= Console.ReadLine();
            string[] tt = z.Split(',');
            int sum5 = 0;

            for (int i=0; i < tt.Length; i++)
            {
               
                sum5 += Convert.ToInt32(tt[i]);
            }
            Console.WriteLine(sum5);


            //////////////////////////////////////////////////////////
            int sum2 = 0;
            for (int i=0; i <100; i++)
            {
               
                if ((i % 2 != 0))
                {
                    sum2 += i;
                }
              
                

            }
            Console.WriteLine("the sum of odd numbers= " + sum2);
            ///////////////////////////////////////////////////////////////////
           
            for(int i=0; i<5; i++)
            {
               

                for (int r = 0; r < i; r++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine(" ");

            }
            //////////////////////////////////////////////////////////////////
            int x = 1;
            for (int i = 0; i < 5; i++)
            {


                for (int r = 0; r < i; r++)
                {
                    Console.Write(x);
                    x += 1;

                }
               
                Console.WriteLine(" ");

            }


        }
    }
}
