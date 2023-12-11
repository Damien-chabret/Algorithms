using METIER.algorithmes;
using System.Diagnostics;

namespace METIER
{
    /// <summary>
    /// Possèdent tous les algos
    /// </summary>
    public class AlgoList
    {
       
        private List<ISort> algoSorts;
        private Dictionary<string, List<int>> algoListe;
        private Dictionary<string, string> algoTimes;

        /// <summary>
        /// Liste des différents algorithmes
        /// </summary>
        public List<ISort> AlgoSorts => algoSorts;

        /// <summary>
        /// Liste des algorithmes par temps
        /// </summary>
        public Dictionary<string, string> AlgoTimes =>  algoTimes;

        /// <summary>
        /// Liste des algorithmes avec la liste triés
        /// </summary>
        public Dictionary<string, List<int>> AlgoListe => algoListe;

        public AlgoList(List<int> liste) 
        {
            this.Init();
            this.ExecuteAll(liste);
        }

        /// <summary>
        /// Initie les différents algorithmes
        /// </summary>
        private void Init()
        {
            this.algoListe = new Dictionary<string, List<int>>();
            this.algoTimes = new Dictionary<string, string>();
            this.algoSorts = new List<ISort>();
            this.algoSorts.Add(new BubbleSort());
        }

        public void ExecuteAll(List<int> suites)
        {
            Stopwatch timer = new Stopwatch();
            foreach (ISort algo in this.algoSorts)
            {
                // Calcule le temps mit
                timer.Start();
                List<int> list = algo.Executer(suites);
                timer.Stop();
                
                this.algoTimes.Add(algo.Name, timer.Elapsed.ToString()); // Ajoute le temps mit pour chaque algo
                this.algoListe.Add(algo.Name, list); // Ajoute la liste trié pour chaque algo

                timer.Reset();

            }
        }
    }
}
