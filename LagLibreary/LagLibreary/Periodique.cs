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

        public Periodique(string titre, string auteur, int annee, int numero, int nbPages) : base(titre, auteur)
        {
            this.annee = annee;
            this.numero = numero;
            this.nbPages = nbPages;
        }
        public int GetAnnee()
        {
            return this.annee;
        }
        public int GetNumero()
        {
            return this.numero;
        }
        public string GetDescription()
        {
            return "Description: " + GetTitre() + " " + GetAuteur() + " " + GetAnnee() + " " + GetNumero() + " " + GetNbPages();
        }

        public int GetNbPages()
        {
            return this.nbPages;
        }
    }
}
