using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class ForLoop
    {
        public static void For()
        {
            // Konsole leeren
            Console.Clear();

            // Text
            Console.WriteLine();
            Console.WriteLine("Der 'For-Loop' ist eine Záhlschleife, und eine besondere Art der kopfgesteuerten Schleife.\n");
            Console.WriteLine("Der Name der for-Schleife leitet sich von Aussagen wie z.B. \"Für alle x...\" ab.\n" +
                "Sie findet daher meistens Verwendung, wenn über Datensätze oder Arrays iteriert werden soll oder\n" +
                "wenn einfach Zahlenbereiche abgezählt werden.\n" +
                "In der Praxis ist die for-Schleife die am häufigsten verwendete Schleife,\n" +
                "da bei ihr alle wichtigen Informationen, die zur Semantik einer Schleife gehören,\n" +
                "im Kopf der Schleife stehen können. So verwenden manche Programmierer sogar Konstrukte\n" +
                " wie for(;x>0;){...}, um while-Schleifen zu emulieren.\n");
            Console.WriteLine("Einfaches Beispiel");
            Console.WriteLine();
            Console.Write("// Der Ausdruck 'int i = 0' deklariert und initialisiert die Variable 'i' das i wird von index abgeleitet\n" +
                "der Ausdruck 'i < 10' ist eine boolsche Bedingung die úberprúft und nach true Ausrewertet wird.\n" +
                "Der Ausdruck 'i++' addiert die Zahl 1 zu 'i'\n" +
                "// For Schleife\n" +
                "for (int i = 0, i < 10; i++)\n" +
                "{\n" +
                "   Console.WriteLine(\"i = {0}\", i);\n" +
                "}\n\n" +
                "Ergebnis:\n\n");

            // For Schleife 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            // Konsole bis Eingabe anhalten  
            Console.ReadKey();
            Console.WriteLine("Fúr ein 'Beispiel an einem Array; Enter drúcken");
            Console.ReadKey();

            ForArray();
        }


        public static void ForArray()
        {
            // Konsole leeren
            Console.Clear();

            // Text
            Console.WriteLine("\n" +
                "// Das Array\n" +
                "int[] number = new int[10];\n" +
                "\n" +
                "// Der For-Loop\n" +
                "for (int i = 0; i < number.length; i++)\n" +
                "{\n" +
                "   number[i] = i;\n" +
                "   Console.WriteLine(\"Der Index von {0} = {1}\", number[i], i);\n" +
                "}\n\n" +
                "Ergebnis:\n\n");

            int[] number = new int[10];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i;
                Console.WriteLine("Der Index von {0} = {1}", number[i], i);
            }

            Console.WriteLine("Ergebnis:\n");
            Console.ReadKey();
            Start.Menue();
        }
    }
}

