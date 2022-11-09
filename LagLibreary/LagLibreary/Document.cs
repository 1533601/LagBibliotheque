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
        public string GetTitre()
        {
            return this.titre;
        }
        public string GetAuteur()
        {
            return this.auteur;
        }
        public int CompareTo(Document other)
        {
            throw new NotImplementedException();
        }
    }
}
