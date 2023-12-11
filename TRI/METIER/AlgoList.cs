using METIER.algorithmes;
using System.Diagnostics;

namespace METIER
{
    /// <summary>
    /// Possèdent tous les algos
    /// </summary>
    public class AlgoList
    {
        private Dictionary<string, ISort> algoList; // liste des algo par classe
        private Dictionary<string, double> algoTimes; // liste de temps par algo
        private List<int> arrayToSort;

        /// <summary>
        /// Tableau à trier
        /// </summary>
        public List<int> ArrayToSort
        {
            get => arrayToSort;
            set => arrayToSort = value; 
        }

       
        /// <summary>
        /// Constructeur de l'algoList
        /// </summary>
        /// <param name="liste"> Liste de valeur à trier </param>
        public AlgoList(List<int> liste) 
        {
            this.arrayToSort = liste; 
            this.algoList = new Dictionary<string, ISort>();    
            this.algoTimes = new Dictionary<string, double>();
            this.InitAlgo();
        }

        /// <summary>
        /// Initie les différents algorithmes
        /// </summary>
        private void InitAlgo()
        {
            this.algoList.Add(new BubbleSort().Name, new BubbleSort());
        }

        /// <summary>
        /// Execute un algorithme 
        /// </summary>
        /// <param name="algo"> algortihme a executer </param>
        /// <returns> Liste triés </returns>
        public List<int> ExecuteAlgo(string algo)
        {
            // Initie les valeurs utiles
            Stopwatch timer = new Stopwatch();
            List<int> sortArray;
            ISort sortAlgo = this.algoList[algo];

            // Execute l'algo
            timer.Start();
            sortArray = sortAlgo.Executer(this.arrayToSort);
            timer.Stop();
            algoTimes.Add(algo, timer.Elapsed.TotalSeconds); // Ajoute le temps au dictionnaire

            return sortArray;
        }

        /// <summary>
        /// Execute tous les algo
        /// </summary>
        public void ExecuteAll()
        {
            foreach (string algo in this.algoList.Keys)
            {
                this.ExecuteAlgo(algo);
            }
        }

        /// <summary>
        /// Récupère tous les algorithmes existants
        /// </summary>
        /// <returns> List des algortihmes </returns>
        public string[] GetAllAlgo()
        {
            return algoList.Keys.ToArray();
        }
    }
}
