using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    public class ListGenerator
    {
        private int size = 0;

        /// <summary>
        /// Create List Generator. Size of the list is equal to 100 by default.
        /// </summary>
        /// <param name="listSize"> size of the list to create</param>
        public ListGenerator(int listSize = 100)
        {
            this.size = listSize;
        }

        /// <summary>
        /// Génère une liste random
        /// </summary>
        /// <returns></returns>
        public List<int> RandomGenerator()
        {
            List<int> list = new List<int>();

            for(int i = 0; i < size; i++)
            {
                list.Add(new Random().Next(0, 100));
            }
            
            return list;
        }
    }
}
