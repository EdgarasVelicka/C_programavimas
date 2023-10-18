using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _paprasti_Aritmetiniai_Veiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kintamieji 
            var a = 12;
            var b = 4;
            var c = 3;

            // 1 d. 
            Console.WriteLine("Suma: " + (a + b));
            Console.WriteLine("Skirtumas: " + (a - b));
            Console.WriteLine("Sandauga: " + (a * b));
            Console.WriteLine("Dalyba: " + (a / b));

            // 2 d.
            Console.WriteLine("Pakelta, kvadratu: " + (Math.Pow(c,2)));
            Console.WriteLine("Pakelta, kubu: " + (Math.Pow(c, 3)));

            // 3 d.
            Console.WriteLine("Triju skaiciu sandauga: " + (a * b * c));
        }
    }
}
