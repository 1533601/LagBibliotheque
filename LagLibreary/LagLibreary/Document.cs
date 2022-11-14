using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public abstract class Document : Icomparable
    {
        string titre;
        string auteur;
        string description;
        Membre emprunteur;
        List<Membre> listeAttente;
        public Document(string titre, string auteur, string description, List<Membre> listeattente) 
        {
            this.titre = titre;
            this.auteur = auteur;
            this.description = description;
            this.listeAttente = listeattente;
            this.emprunteur = null;
        }
        public bool EstDisponible()
        {
            if(emprunteur == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetTitre()
        {
            return this.titre;
        }
        public void SetTitre(string titre)
        {
            this.titre = titre;
        }
        public string GetAuteur()
        {
            return this.auteur;
        }
        public void SetAuteur(string auteur)
        {
            this.auteur = auteur;
        }
        public Membre GetEmprunteur()
        {
            return this.emprunteur;
        }
        public void SetEmprunteur(Membre emprunteur)
        {
            this.emprunteur = emprunteur;
        }
        public List<Membre> GetListeAttente()
        {
            return this.listeAttente;
        }
        public string Description()
        {
            return this.description;
        }
        public bool AjouterMembreListeAttente(Membre ajout)
        {
            if (this.emprunteur != null)
            {
                if (listeAttente.Contains(ajout) || ajout == this.emprunteur || listeAttente.Count >= 2)
                {
                    return false;
                }
                else
                {
                    listeAttente.Add(ajout);
                    return true;
                }
            }
            return false;
        }
        public bool EnleverMembreListeAttente(Membre retrait)
        {
            if(!listeAttente.Contains(retrait))
            {
                return false;
            }
            else
            {
                listeAttente.Remove(retrait);
                return true;
            }
        }
        public int CompareTo(Document other)
        {
            if(this.titre == other.GetTitre())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
