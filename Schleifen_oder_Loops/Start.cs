using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class Start
    {
        // Variablen
        public static string menueInsert;


        public static void ConsoleConfig()
        {
            Console.Clear();
            Console.SetWindowSize(135, 40);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void Menue()
        {
            ConsoleConfig();
            Console.WriteLine();
            Console.WriteLine("Moin, bitte treffe eine Auswahl.");
            Console.WriteLine();
            Console.WriteLine("While Loop........... = 1");
            Console.WriteLine("Do-While Loop........ = 2");
            Console.WriteLine("For-Loop............. = 3");
            Console.WriteLine("Foreach-Loop......... = 4");
            Console.WriteLine("Break und Continue... = 5");
            Console.WriteLine("Aufgaben Loops....... = A");
            Console.WriteLine();
            Console.WriteLine("Beenden.............. = E");
            MenueInsert();
        }

        public static void MenueInsert()
        {
            menueInsert = Console.ReadLine();
            if (menueInsert == "1" || menueInsert == "2" || menueInsert == "3" || menueInsert == "4" || menueInsert == "5" ||
                menueInsert == "E" || menueInsert == "e" || menueInsert == "a" || menueInsert == "A")
            {
                MenueSwitch();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Falsche Eingabe, bitte nur die vorgegebenen Zeichen verwenden!");
                Console.ReadKey();
                Menue();
            }
        }

        public static void MenueSwitch()
        {
            switch (menueInsert)
            {

                case "1":
                    WhileLoop.While();
                    break;

                case "2":
                    DoWhileLoop.DoWhile();
                    break;

                case "3":
                    ForLoop.For();
                    break;

                case "4":
                    ForEachLoop.ForEach();
                    break;

                case "5":
                    BreakContinue.BC();
                    break;

                case "A":
                    WhileLoop.While();
                    break;

                case "a":
                    WhileLoop.While();
                    break;

                case "E":
                    Environment.Exit(0);
                    break;

                case "e":
                    Environment.Exit(0);
                    break;


            }
        }
    }
}
