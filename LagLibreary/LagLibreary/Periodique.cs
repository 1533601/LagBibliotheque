using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Periodique : Document, IDescription, IImprime
    {
        int annee;
        int numero;
        int nbPages;

        public Periodique(string titre, string auteur,string description, List<Membre> listeAttente, int annee, int numero, int nbPages) : base(titre, auteur, description, listeAttente)
        {
            this.annee = annee;
            this.numero = numero;
            this.nbPages = nbPages;
        }
        /// <summary>
        /// retourne annee
        /// </summary>
        /// <returns></returns>
        public int GetAnnee()
        {
            return this.annee;
        }
        /// <summary>
        /// retourne le numero
        /// </summary>
        /// <returns></returns>
        public int GetNumero()
        {
            return this.numero;
        }
        /// <summary>
        /// retourne la description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Description();
        }
        /// <summary>
        /// retourne le nombre de page
        /// </summary>
        /// <returns></returns>
        public int GetNbPages()
        {
            return this.nbPages;
        }
    }
}
