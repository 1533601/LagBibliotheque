using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Livre : Document, IDescription, IImprime
    {
        string editeur;
        DateTime datePublication;
        int nbPages;
        string isbn;
        string cote;

        public Livre (string titre, string auteur,string description, string editeur,List<Membre> listeAttente, DateTime datePublication, int nbPages, string isbn, string cote) : base(titre, auteur, description, listeAttente)
        {
            this.editeur = editeur;
            this.datePublication = datePublication;
            this.nbPages = nbPages;
            this.isbn = isbn;
            this.cote = cote;
        }
        /// <summary>
        /// retourne l'éditeur
        /// </summary>
        /// <returns></returns>
        public string GetEditeur()
        {
            return this.editeur;
        }
        /// <summary>
        /// retourne la date de publication
        /// </summary>
        /// <returns></returns>
        public DateTime GetDatePublication()
        {
            return this.datePublication;
        }
        /// <summary>
        /// retourne ISBN
        /// </summary>
        /// <returns></returns>
        public string GetISBN()
        {
            return this.isbn;
        }
        /// <summary>
        /// retourne la cote
        /// </summary>
        /// <returns></returns>
        public string GetCote()
        {
            return this.cote;
        }
        /// <summary>
        /// retourne la decription
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
