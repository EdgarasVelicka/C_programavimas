using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // 1 d.
            Console.WriteLine("Labas, Edgarai");

            // 2 d.
            var amzius = 36;
            Console.WriteLine("Įvestas amžius" +" "+ amzius +" "+ "metai");

            // 3 d.
            int skaicius = 25;
            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}{skaicius}");

            // 4 d.
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius} {skaicius}");

        }
    }
}
