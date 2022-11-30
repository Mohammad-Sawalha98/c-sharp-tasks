using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employeeInfo = new Employee("ahmad", "1558525", 25 , 10 ,1998);
            //employeeInfo.employeeDetails();
            //employeeInfo.calculateAge(10,5,1998);

            Manager managerInfo = new Manager("Mohammad",  "123456789", 10 , 12 , 1998);
            managerInfo.employeeDetails();
            managerInfo.calculateAge();
            


        }
    }
}
