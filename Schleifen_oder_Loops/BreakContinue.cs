using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class BreakContinue
    {
        public static string eingabe = "standard";
        public static void BC()
        {
            // Konsole leeren
            Console.Clear();


            int num1 = 1;

            while (num1 < 2)
            {
                Console.WriteLine("Dieser Loop wird nie enden!!!");
                if (eingabe == "e")
                {
                    break;
                }
                eingabe = Console.ReadLine();
                BC();
            }

            Console.ReadKey();
            Start.Menue();
        }
    }
}
