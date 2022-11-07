using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Document : Icomparable
    {
        string titre;
        string auteur;
        Membre emprunter;
        Membre[] listeAttente;

        public Document(string titre, string auteur)
        {
            this.titre = titre;
            this.auteur = auteur;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
