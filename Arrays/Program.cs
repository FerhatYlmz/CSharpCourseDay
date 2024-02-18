using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Ferhat", "Ahmet", "Ali" };

            string[] students2 = { "Ferhat", "Ahmet", "Ali" };

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Kayseri","Sivas","Adana"},
                { "İstanbul","İzmit","Balıkesir"},
                { "Ağrı","Çanakkale","Antalya"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
