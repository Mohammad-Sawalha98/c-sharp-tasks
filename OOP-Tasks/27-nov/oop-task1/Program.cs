using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            info personal = new info("ali", "male", "ali@gmail.com", "0797620295", 25, 998102404);
            personal.infos();
        }
    }
}
