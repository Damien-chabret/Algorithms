﻿using System.Collections.Generic;
using VoyageurDeCommerce.modele.distances;
using VoyageurDeCommerce.vuemodele;

namespace VoyageurDeCommerce.modele.lieux
{
    ///<summary>Tour (ensemble ordonné de lieu parcouru dans l'ordre avec retour au point de départ)</summary>
    public class Tournee
    {
        /// <summary>Liste des lieux dans l'ordre de visite</summary>
        private List<Lieu> listeLieux;
        public List<Lieu> ListeLieux
        {
            get => listeLieux;
            set => listeLieux = value;
        }

        /// <summary>Constructeur par défaut</summary>
        public Tournee()
        {
            this.listeLieux = new List<Lieu>();
        }

        /// <summary>Constructeur par copie</summary>
        public Tournee(Tournee modele)
        {
            this.listeLieux = new List<Lieu>(modele.listeLieux);
        }

        /// <summary>
        /// Ajoute un lieu à la tournée (fin)
        /// </summary>
        /// <param name="lieu">Le lieu à ajouter</param>
        public void Add(Lieu lieu)
        {
            this.ListeLieux.Add(lieu);
        }

        /// <summary>Distance totale de la tournée</summary>
        public int Distance
        {
            get
            {
                int result = 0;
                for(int i = 0; i < this.listeLieux.Count - 1; i++)
                {
                    result += FloydWarshall.Distance(this.listeLieux[i], this.listeLieux[i + 1]);
                }
                result += FloydWarshall.Distance(listeLieux[this.listeLieux.Count - 1], this.listeLieux[0]);
                return result;
            }
        }

        public override string ToString()
        {
            string resultat = "";

            foreach(Lieu l in listeLieux)
            {
                resultat += $"{l.Nom} => ";
            }
            resultat += listeLieux[0].Nom;
            return resultat ;
        }
    }
}
