using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class WhileLoop
    {
        public static void While()
        {
            // Konsole leeren
            Console.Clear();

            // Deklarieren und initialisieren der Variablen
            int temp = 0;

            // Text
            Console.WriteLine();
            Console.WriteLine("Der 'While-Loop' prúft erst die Bedingung und wird dann solange ausgefúrt bis die Bedingung nicht mehr erfúllt wird");
            Console.WriteLine("Ein While-Loop kónnte z.B. eine Temperatur-Steuerung einer Heizung dienen");
            Console.WriteLine("Solange die Temperatur kleiner 22 Grad Celsius ist wird geheizt.\n" +
                "Bei Erreichen der Temperatur wird das Heizen unterbrochen bis die Temperatur unter 22 Grad Celsius fállt.\n");
            Console.WriteLine();
            Console.Write("// Deklarieren und initialisieren der Variablen\n" +
                "int temp = 0;\n" +
                "\n" +
                "// Kopfgesteuerte Schleife\n" +
                "while(temp < 22)\n" +
                "{\n" +
                "   temp++; // == temp += 1  es wird immer 1 aufaddiert\n" +
                "   Console.WriteLine(\"Temperatur wird um 1 erhóht, bitte Enter\");\n" +
                "   Console.ReadKey();\n" +
                "   Console.WriteLine(temp);\n" +
                "}\n\n" +
                "Ergebnis\n");

            // Kopfgesteuerte Schleife 
            while(temp < 22)
            {
                temp++; // == num1 += 1  es wird immer 1 aufaddiert
                Console.WriteLine("Temperatur wird um 1 erhóht, bitte Enter");
                Console.ReadKey();
                Console.WriteLine(temp);
            }

            // Konsole bis Eingabe anhalten  
            Console.ReadKey();
            Console.WriteLine("22 Grad wurden erreicht");
            Console.ReadKey();
            Start.Menue();

        }
    }
}
