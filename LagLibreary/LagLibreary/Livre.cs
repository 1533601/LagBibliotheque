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

        public Livre (string titre, string auteur, string editeur, DateTime datePublication, int nbPages, string isbn, string cote) : base(titre, auteur)
        {
            this.editeur = editeur;
            this.datePublication = datePublication;
            this.nbPages = nbPages;
            this.isbn = isbn;
            this.cote = cote;
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public int GetNbPages()
        {
            throw new NotImplementedException();
        }
    }
}
