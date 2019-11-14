using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Roshan Gurung  ";
            Console.WriteLine("Trim:'{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var names = fullName.Split(' ');
            Console.WriteLine("First Name:" + names [0]);
            Console.WriteLine("Last Name:" + names [1]);

            Console.WriteLine(fullName.Replace("Roshan","Jack"));
            

            var str = "27";
            var age =  Convert.ToByte(str);
            Console.WriteLine(age);
            Console.ReadLine();




        }
    }
}
/////Trim: 'Roshan Gurung', ToUpper: 'ROSHAN GURUNG', First Name : Roshan, Last Name: Gurung, Jack Gurung, 27////////
