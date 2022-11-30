using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
   internal class Employee
    {
     public string name { get; set; }
      
        public string ID { get; set; }
        public DateTime dateOfbairth { get; set; }

        public Employee(string name, string ID, int day, int month, int year)
        {
            this.name = name;
            this.ID = ID;
            dateOfbairth = new DateTime(year,month,day);
        }

        public virtual void employeeDetails()
        {
            Console.WriteLine($"Employee name is: {name} and his/her date of birth is:{dateOfbairth} and his/her ID is: {ID}");
        }


        public void calculateAge()
        {

            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(dateOfbairth);

            Console.WriteLine((int)value.TotalDays / 365);
        }

    }


         class Manager : Employee
    {
        public Manager (string name, string ID, int day, int month, int year) : base (name, ID,  day,  month, year)
        {
        
        
        }

        //public override void employeeDetails()
        //{
        //    Console.WriteLine($"Manager name is: {name} and his/her date of birth is:{dateOfbairth} and his/her ID is: {ID}");
        //}
    }






}
