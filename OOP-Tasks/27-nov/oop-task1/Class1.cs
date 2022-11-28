using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task1
{
    public class info
    {
        private string name;
        private string gender;
        private string email;
        private string phone;
        private int age;
        private int ID;


        //construct
        //method
        //bring method in main
       
        public info(string infoname, string infogender, string infoemail, string infophone, int infoage, int infoID)
        {
            name= infoname;
            gender= infogender;
            email= infoemail;
            ID= infoID;


            string validnum = infophone.Substring(0,3);
            if (validnum == "077" || validnum=="078" || validnum=="079")
            {
                phone = infophone;
            }
            else
            {
                Console.WriteLine("please inter a valid number");
            }
          


            if(infoage>60 || infoage < 18)
            {
                Console.WriteLine("your age is not sutable");
            }
            else
            {
                age = infoage;
            }


           
        }
       public void infos()
        {
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"gender is: {gender}");
            Console.WriteLine($"email is: {email}");
            Console.WriteLine($"phone is: {phone}");
            Console.WriteLine($"age is: {age}");
            Console.WriteLine($"ID is: {ID}");


        }
       
    }
}
