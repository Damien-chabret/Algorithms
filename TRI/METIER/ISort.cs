using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    /// <summary>
    /// Interface qui va être implémenter par les algo de tri
    /// </summary>
    public interface ISort
    {
        /// <summary>
        /// Nom de l'algorithme
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Exécute l'algorithme de tri
        /// </summary>
        /// <param name="suites"> suites de nombres qui sera trié </param>
        /// <returns> Nouvelle liste triés </returns>
        public List<int> Executer(List<int> suites);
    }
}
