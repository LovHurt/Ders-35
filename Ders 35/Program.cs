using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";

            foreach(var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
