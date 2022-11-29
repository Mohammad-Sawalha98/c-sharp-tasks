using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Car car = new Car("jordan", 2010, "ford", 5000, "fusion", "15585", "red");
            Console.WriteLine(car.carDetail());

            Test test = new Test("germany", 2020, "BMW", 20000, "fusion", "17875", "green","ahmad");
            Console.WriteLine(test.testDetail());
        }
    }
}
