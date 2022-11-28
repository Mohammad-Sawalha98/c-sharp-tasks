using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void sum()
        {
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("inter num" + i);
                int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }

            Console.WriteLine("The sum of 10 numbers is :" + sum);
            int avg = sum / 10;
            Console.WriteLine("The avg of 10 numbers is :" + avg);
        }

        static void cube()
        {
            Console.WriteLine("inter a number to cube it:");
            int r = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                Console.WriteLine("Number is :" + i + " and cube of the" + i + " is :" + (i * i * i));
            }
        }

        static void getyears(int[] year)
        {

            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    Console.WriteLine(year[i]);
                }

            }


        }

        static void days()
        {
            Console.WriteLine("inter your age in years");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageindays = age * 365;
            Console.WriteLine(ageindays);

        }

        static void legs()
        {
            Console.WriteLine("how many chickens do you have?");
            int check=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many cows do you have?");
            int cow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many pigs do you have?");
            int pig = Convert.ToInt32(Console.ReadLine());

            int numoflegs=(check*2)+(cow*4)+(pig*4);
            Console.WriteLine("your animals have "+numoflegs+" legs");
        }




        static void login(string[] one, string[] tow)
        {
            Console.WriteLine("please inter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("please inter your password:");
            string password = Console.ReadLine();
            bool result = false;
            for (int i = 0; i < one.Length; i++)
            {
                if (name == one[i] && password == tow[i])
                {
                     result = true;
                    
                }
            }
        
            if (result == true)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("faield");
            }


        }


        static void power()
        {
            Console.WriteLine("inter a number");
            int p = Convert.ToInt32(Console.ReadLine());
            int power = p * p;
            Console.WriteLine(power);
        }

        static void leap()
        {
            Console.WriteLine("inter a year between 1900 and 2025:");
            int y=Convert.ToInt32(Console.ReadLine());
            if(y>1900 &&y<2024)
            {
                if (y%4==0)
                {
                    Console.WriteLine($"{y} is a leap yaer");
                }
                else
                {
                    Console.WriteLine($"{y} is not a leap year");
                }

            }

           
           
        }


        static void prime()
        {
            // اذا كانت مجموع ارقام العدد ما بتقسم على (3) بكون برايم
            Console.WriteLine("inter a number:");
            int pri=Convert.ToInt32(Console.ReadLine());
            if ((pri % 2 == 0 || pri % 3 == 0 || pri % 5 == 0 || pri%7==0) && (pri != 2 && pri != 3 && pri != 5 && pri != 7))
            {
                Console.WriteLine(pri + " is not a prime number");

            }
            else
            {
                Console.WriteLine(pri + " is a prime number");
            }


        }



        static void sentance()
        {
            Console.WriteLine("please write a sentance:");
            string sent=Console.ReadLine();
            string[] strings = sent.Split(' ');
            Console.WriteLine(strings.Length);
        }


        static void Main(string[] args) 
        {
            //task1(sum and average)

            //sum();

            /////////////////////////////////////////////
            //Task2
            //cube();

            /////////////////////////////////////////////
            //Task3

            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //getyears(years);

            /////////////////////////////////////////////
            //Task4

            //days();

            /////////////////////////////////////////////////
            //Task5

            //legs();


            /////////////////////////////////////////////////
            //Task6
            //string[] names = { "ali", "mohammad", "ahmad" };
            //string[] passwords = { "12345", "1234", "123" };
            //login(names, passwords);

            //////////////////////////////////////////////////
            //Task7

            //power();

            //////////////////////////////////////////////////
            //Task8
            //leap();


            //////////////////////////////////////////////////
            //Task9
            prime();


            /////////////////////////////////////////////////
            //Task10

            //sentance();



        }

        
    }
}
