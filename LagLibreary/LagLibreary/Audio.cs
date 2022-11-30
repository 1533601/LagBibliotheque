using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Audio : Document, IDescription
    {
        int nbMinutes;
        string format;

        public Audio (string titre, string auteur,string description,List<Membre> listeAttente, int nbMinutes, string format) : base(titre, auteur, description, listeAttente)
        {
            this.nbMinutes = nbMinutes;
            this.format = format;
        }
        /// <summary>
        /// retourne le nombre de minute
        /// </summary>
        /// <returns></returns>
        public int GetNbMinutes()
        {
            return this.nbMinutes;
        }
        /// <summary>
        /// retourne le format audio
        /// </summary>
        /// <returns></returns>
        public string GetFormat()
        {
            return this.format;
        }
        /// <summary>
        /// retourne la description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Description();
        }
    }
}
