using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// <summary>
        /// retourne si le document est disponible
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// retourne le titre
        /// </summary>
        /// <returns></returns>
        public string GetTitre()
        {
            return this.titre;
        }
        /// <summary>
        /// assigne un titre au document
        /// </summary>
        /// <param name="titre"></param>
        public void SetTitre(string titre)
        {
            this.titre = titre;
        }
        /// <summary>
        /// retourne l'auteur au document
        /// </summary>
        /// <returns></returns>
        public string GetAuteur()
        {
            return this.auteur;
        }
        /// <summary>
        /// assigne un auteur
        /// </summary>
        /// <param name="auteur"></param>
        public void SetAuteur(string auteur)
        {
            this.auteur = auteur;
        }
        /// <summary>
        /// retourne l'emprunteur
        /// </summary>
        /// <returns></returns>
        public Membre GetEmprunteur()
        {
            return this.emprunteur;
        }
        /// <summary>
        /// assign un emprunteur
        /// </summary>
        /// <param name="emprunteur"></param>
        public void SetEmprunteur(Membre emprunteur)
        {
            this.emprunteur = emprunteur;
        }
        /// <summary>
        /// retourne la liste d'attente du document
        /// </summary>
        /// <returns></returns>
        public List<Membre> GetListeAttente()
        {
            return this.listeAttente;
        }
        /// <summary>
        /// retourne la description du document
        /// </summary>
        /// <returns></returns>
        public string Description()
        {
            return this.description;
        }
        /// <summary>
        /// Ajoute un membre à liste d'attente du document
        /// </summary>
        /// <param name="ajout"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Enleve un membre de la liste d'attente
        /// </summary>
        /// <param name="retrait"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Compare deux document pour voir si ils sont similaire selon le nom
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
