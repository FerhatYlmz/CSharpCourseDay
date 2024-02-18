using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");


            

            double number6 = 11.25;
            decimal number7 = 10.6m;
            char character = 'A';
            bool condition = false;
            byte number5 = 255; //0 ile 255 arasında
            short number4 = 32767;
            int number1 = 5;
            int number2 = 10;
            long number3 = 2147483647; //19 karakter
            var number8 = 15;
            number8 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Number8 is {0}", number8);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10,Tuesday=25,Wednesday=22,Thursday=20,Friday=26,Saturday,Sunday  
    }
}
