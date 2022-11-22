using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _21.nov._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = 7;
            if (x > y)
            {
                Console.WriteLine("the biggest is :" +  x) ;
            }
            else
            { Console.WriteLine("the biggest is :" + y ); }

///////////////////////////////////////////////////////////////////////////

           int r= Convert.ToInt32(Console.ReadLine()) ;

            if (r < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
                Console.WriteLine("The sign is +");
            /////////////////////////////////////////////////////////////////////
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a>b && b > c)
            {
                Console.WriteLine(a +", "+b+", "+c);
                        
            }

            else if (b > a && a > c)
            {
                Console.WriteLine(b + "," + a + "," + c);
            }

            else if (c>b && b>a )
            {
                Console.WriteLine(c + "," + b + "," + a);
            }

            else if (a > c && c > b)
            {
                Console.WriteLine(a + "," + c + "," + b);
            }

            else if (b > c && c > a)
            {
                Console.WriteLine(b + "," + c + "," + a);
            }

            else
            {
                Console.WriteLine(c + "," + a + "," + b);
            }
            //////////////////////////////////////////////////////////
            int[] arr = { 1, 2, 3, 4, 5 };
            if (arr[0] > arr[1] && arr[0] > arr[2] && arr[0] > arr[3] && arr[0] > arr[4]) 
            {
                Console.WriteLine(arr[0]);
            }

            else if (arr[1] > arr[0] && arr[1] > arr[2] && arr[1] > arr[3] && arr[1] > arr[4]) 
            {
                Console.WriteLine(arr[1]);
            }

            else if (arr[2] > arr[0] && arr[2] > arr[1] && arr[2] > arr[3] && arr[2] > arr[4]) 
            {
                Console.WriteLine(arr[2]);
            }

            else if (arr[3] > arr[0] && arr[3] > arr[1] && arr[3] > arr[2] && arr[3] > arr[4]) 
            {
                Console.WriteLine(arr[3]);
            }

            else if (arr[4] > arr[1] && arr[4] > arr[2] && arr[4] > arr[3] && arr[4] > arr[0])
            {
                Console.WriteLine(arr[4]);
            }
            //////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("inter distance per kilo:");
            double kilo = Convert.ToInt32(Console.ReadLine());
            double mile =  kilo/ 1.6;
            Console.WriteLine("distance in mile:" + mile);
            //////////////////////////////////////////////////////////////
            Console.WriteLine("inter time:");
            int hours = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int hourmin = hours * 60;
            Console.WriteLine(" time in minutes:" + Convert.ToInt32(hourmin + min)  );
            /////////////////////////////////////////////////////////////////// 

            Console.WriteLine("inter time in min:");
            int timeinmin = Convert.ToInt32(Console.ReadLine());
            double retur = timeinmin / 60;
            double retmin= retur% 60;
            Console.WriteLine(" time is:" + (retur + " hours"+ " " +retmin + " min"));
            ///////////////////////////////////////////////////// 
            string[] arra = { "MohaMmad", "abdallah", " saleh", "mohammad", " sawalha" };

            Console.WriteLine(arra[0].Substring(1, 3));
            Console.WriteLine(arra[1].Substring(1, 3));
            Console.WriteLine(arra[2].Substring(1, 3));
            Console.WriteLine(arra[3].Substring(1, 3));
            Console.WriteLine(arra[4].Substring(1, 3));

        }
    }
}
