using METIER;
using System;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 234, 233, 1, 0, 34, 23, 99, 99, 23, 1492, 43 };
            AlgoList algoList = new AlgoList(list);

            // Affiche la liste des algo 
            Console.WriteLine("Liste des algorithmes : ");
            foreach(ISort algo in algoList.AlgoSorts)
            {
                Console.WriteLine(algo.Name);
            }

            // Affiche la rapidité des algorithmes 
            Console.WriteLine("\nRapidité des algorithmes : ");
            foreach((string algoName, string algoVitesse) in algoList.AlgoTimes) 
            {
                Console.WriteLine(algoName + " => " + algoVitesse + " secondes");
            }

            /// =======================================================================
            /// DETAILS 
            /// =======================================================================
            // Liste de nombres de bases
            Console.WriteLine("\nListe de base : ");
            Console.WriteLine(String.Join(" < ", list));

            // Liste des nombres triés 
            foreach((string algoName, List<int> liste) in algoList.AlgoListe)
            {
                Console.WriteLine("\n" + algoName);
                Console.WriteLine(String.Join(" < ", liste));
            }

        }
    }
}