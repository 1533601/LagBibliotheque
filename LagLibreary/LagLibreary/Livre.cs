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

        public Livre (string titre, string auteur,string description,  string editeur, DateTime datePublication, int nbPages, string isbn, string cote) : base(titre, auteur, description)
        {
            this.editeur = editeur;
            this.datePublication = datePublication;
            this.nbPages = nbPages;
            this.isbn = isbn;
            this.cote = cote;
        }
        public string GetEditeur()
        {
            return this.editeur;
        }
        public DateTime GetDatePublication()
        {
            return this.datePublication;
        }
        public string GetISBN()
        {
            return this.isbn;
        }
        public string GetCote()
        {
            return this.cote;
        }
        public string GetDescription()
        {
            return Description();
        }

        public int GetNbPages()
        {
            return this.nbPages;
        }
    }
}
