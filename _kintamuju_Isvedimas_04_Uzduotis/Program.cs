using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _kintamuju_Isvedimas_04_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kintamieji
            var marke = "Skoda";
            var modelis = "Superb";
            var metai = "2013";
            var rida = "224000 km";

            // Isvedimas
            Console.WriteLine(marke+" "+modelis+", metai: "+metai+", rida: "+rida);    

        }
    }
}
