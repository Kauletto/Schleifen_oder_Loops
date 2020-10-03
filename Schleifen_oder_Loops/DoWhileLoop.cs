using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class DoWhileLoop
    {
        public static void DoWhile()
        {
            // Konsole leeren
            Console.Clear();

            // Deklarieren und initialisieren der Variablen
            int temp = 25;

            // Text
            Console.WriteLine();
            Console.WriteLine("Der 'Do-While-Loop' wird erst einmal ausgefúhrt und prúft dann die Bedingung");
            Console.WriteLine("Fußgesteuerte Schleifen finden recht selten Verwendung.\n" +
                "Wenn, dann aufgrund ihrer definierenden Eigenschaft: Sie soll immer mindestens ein Mal ausgeführt werden.\n" +
                "Dies dient meistens dazu, in einer fußgesteuerten Schleife gesetzte Werte garantiert zu initialisieren und\n" +
                "ein Ergebnis liefern zu können, auch wenn die Bedingung zum Sprung zurück zum Schleifenkopf potentiell nie erfüllt wird.\n" +
                "Das beste Beispiel dafür sind Listendurchläufe.");
            
            Console.WriteLine();
            Console.Write("// Deklarieren und initialisieren der Variablen\n" +
                "int temp = 25;\n" +
                "\n" +
                "// Fussgesteuerte Schleife\n" +
                "do\n" +
                "{\n" +
                "   temp++; // == temp += 1  es wird immer 1 aufaddiert\n" +
                "   Console.WriteLine(\"Temperatur wird um 1 erhóht, bitte Enter\");\n" +
                "   Console.ReadKey();\n" +
                "   Console.WriteLine(temp);\n" +
                "}\n" +
                "while (temp < 22);\n\n" +
                "Ergebnis\n");

            // Fussgesteuerte Schleife 
            do
            {
                temp++; // == num1 += 1  es wird immer 1 aufaddiert
                Console.WriteLine("Temperatur wird um 1 erhóht, bitte Enter");
                Console.ReadKey();
                Console.WriteLine(temp);
            }
            while (temp < 22) ;

            // Konsole bis Eingabe anhalten  
            Console.ReadKey();
            Console.WriteLine("22 Grad wurden úberschritten");
            Console.ReadKey();
            Start.Menue();

        }
    }
}
