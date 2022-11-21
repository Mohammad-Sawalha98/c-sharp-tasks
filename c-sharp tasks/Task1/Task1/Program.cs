using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);


            int mynumber = 5 ;
            double mydouple = 5.5 ;
            char litter = 'a' ;
            string hi = "hi";
            bool tru = true;
            const int pie = 3;

            Console.WriteLine(mynumber);
            Console.WriteLine(mydouple);
            Console.WriteLine(litter);
            Console.WriteLine(hi);
            Console.WriteLine(tru);
            Console.WriteLine(pie);


            string[] cars = {"BMW", "OPEL", "KIA"};
            Console.WriteLine(cars);

            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter birth:");
            string birth = Console.ReadLine();
            Console.WriteLine(firstname+" " +lastname + " " +birth);

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(num);




            int[] sum = { 2, 5, 8 };
            Console.WriteLine(sum[0] + sum[1]+ sum[2]);
        }
    }
}
