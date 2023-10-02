using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Adınızı Giriniz");

            string ad;
            ad = Console.ReadLine();

            Console.WriteLine("Hoş geldin " + ad);

            Console.ReadLine(); 
        }
    }
}
