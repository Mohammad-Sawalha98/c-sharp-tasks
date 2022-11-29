using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.Car;

namespace Task2
{
    internal class Test : Car
    {

        public Test(string make, int year, string type, int price, string model, string palletNo, string color, string name) : base( make,  year,  type,  price,  model,  palletNo,  color)
        {
        this.name= name;
        }
        private string name;
        public string testDetail()
        {
            return $"Country origin: {make} \n Production year: {year} \n type: {type} \n Model: {model} \n Pallet No#: {palletNo} \n Color: {color} \n Price: {price} \n Driver name:{name}";

        }

    }
}
