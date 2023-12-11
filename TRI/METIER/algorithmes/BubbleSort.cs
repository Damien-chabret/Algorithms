using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER.algorithmes
{
    /// <summary>
    /// Bubble Sort Algorithme
    /// </summary>
    internal class BubbleSort : ISort
    {
        public string Name => "Bubble sort";

        public List<int> Executer(List<int> suites)
        {
            List<int> result = new List<int>();

            // Regarde la liste de nombre de base
            foreach (int suite in suites)
            {
                result.Add(suite);
            }

            return result;
        }
    }
}
