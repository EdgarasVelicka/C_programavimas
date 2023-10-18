using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daugyba_06_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 d. Daugybos lentele
            
            Console.WriteLine("Daugyba is 4");
            Console.WriteLine("4 * 0 = " + 4 * 0);
            Console.WriteLine("4 * 1 = " + 4 * 1);
            Console.WriteLine("4 * 2 = " + 4 * 2);   
            Console.WriteLine("4 * 3 = " + 4 * 3);
            Console.WriteLine("4 * 4 = " + 4 * 4);
            Console.WriteLine("4 * 5 = " + 4 * 5);   
            Console.WriteLine("4 * 6 = " + 4 * 6);
            Console.WriteLine("4 * 7 = " + 4 * 7);
            Console.WriteLine("4 * 8 = " + 4 * 8);
            Console.WriteLine("4 * 9 = " + 4 * 9);
            Console.WriteLine("4 * 10 = " + 4 * 10);

            // 2 d. 
            Console.WriteLine("272 skaitmenu sandauga");
            int dvizenklis = 272;
            int vienzenklis = 1;

            while (dvizenklis > 0) 
            {
                int digit = dvizenklis % 10;
                vienzenklis *= digit;
                dvizenklis /= 10;
            }
            Console.WriteLine(vienzenklis);





        }
    }
}
