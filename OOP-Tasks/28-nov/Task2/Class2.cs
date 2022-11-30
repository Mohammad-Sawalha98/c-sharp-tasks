using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class Car
    {

        public string make { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string model { get; set; }
        public string palletNo { get; set; }
        public string color { get; set; }
        
        private bool   enginState  = false;
        //public Car() { }
        public Car(string make, int year, string type, int price, string model, string palletNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
        }

        
        public void engine()
        {
           
            if (this.enginState ==false)
            {
                Console.WriteLine("engine started!");
                this.enginState= true;
            }
            else
            {
                Console.WriteLine("engine stoped!");
                this.enginState = false ;
            }

        }


        public string carDetail()
        {
            return $"Country origin: {make} \n Production year: {year} \n type: {type} \n Model: {model} \n Pallet No#: {palletNo} \n Color: {color} \n Price: {price}";
       
        }

        public void calculateDistance(int liters) {
            int kiloCovaragePerLiter = 10;
            Console.WriteLine(kiloCovaragePerLiter * liters);
        
        }


       



    }


}
