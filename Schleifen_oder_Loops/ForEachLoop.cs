using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_oder_Loops
{
    class ForEachLoop
    {
        public static void ForEach()
        {
            // Konsole leeren
            Console.Clear();

            // Text
            Console.WriteLine("\n" +
                "/* Das Array. Diesmal bleiben die eckigen Klammern leer.\n" +
                " * Dadurch kann man im anschliessenden geschweiften Klammerpaar die Werte zuweisen.\n" +
                " * Beispiel:\n" +
                " * string[] namenListe = new string[]\n" +
                " * {\n" +
                " *   \"Klaus\",\n" +
                " *   \"Petra\",\n" +
                " *   \"Kurt\",\n" +
                " *   \"Heribert\",\n" +
                " *   \"Norchen\",\n" +
                " *   \"Florian\"\n" +
                " * };\n" +
                " */\n\n\n" +
                "// Der ForEach-Loop\n" +
                "// Besonderheit: Der ForEach-Loop stellt nur eine Kopie der iterierten Werte dar. Kein Wert kann verándert werden.\n" +
                "// Eine Wertzuweisung funktioniert in einem For-Loop.\n\n" +
                "foreach (string name in namenListe)\n" +
                "{\n" +
                "   Console.ReadKey(),\n" +
                "   Console.WriteLine(name);\n" +
                "}\n\n\n" +
                "Ergebnis: drúcke Enter\n");

            /* Das Array. Diesmal bleiben die eckigen Klammern leer. Dadurch kann man im anschliessenden geschweiften Klammerpaar die Werte zuweisen.
             * Beispiel:
             * string[] namenListe = new string[]
             * {
             *      "Klaus",
             *      "Petra",
             *      "Kurt",
             *      "Heribert",
             *      "Norchen",
             *      "Florian"
             * };
             */

            string[] namenListe = new string[]
            {
                "Klaus",
                "Petra",
                "Kurt",
                "Heribert",
                "Norchen",
                "Florian"
            };

            // Der ForEach-Loop
            foreach (string name in namenListe)
            {
                Console.ReadKey();
                Console.WriteLine(name);
                
            }

            Console.ReadKey();
            Start.Menue();
        }
    }
}
