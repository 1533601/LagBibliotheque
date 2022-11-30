using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Membre
    {
        string nom;
        List<Document> listeEmprunts;
        int noMembre;
        static int nbMembresTotal = 1;
        public Membre(string nom)
        {
            this.noMembre = nbMembresTotal++;          
            this.nom = nom;
            this.listeEmprunts = new List<Document>();
        }
        /// <summary>
        /// retourne le nom du membre
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return this.nom;
        }
        /// <summary>
        /// assign un nom au membre
        /// </summary>
        /// <param name="value"></param>
        public void SetNom(string value)
        {
            this.nom = value;
        }
        /// <summary>
        /// retourne la liste d'emprunt du membre
        /// </summary>
        /// <returns></returns>
        public List<Document> GetListeEmprunt()
        {
            return this.listeEmprunts;
        }
        /// <summary>
        /// retourne le nombre de document emprunté que le membre posède
        /// </summary>
        /// <returns></returns>
        public int GetNbEmprunts()
        {
            return this.listeEmprunts.Count;
        }
        /// <summary>
        /// retourne le no. du membre
        /// </summary>
        /// <returns></returns>
        public int GetNoMembre()
        {
            return this.noMembre;
        }
        /// <summary>
        /// Ajoute un document à la liste d'emprunt du membre
        /// </summary>
        /// <param name="nouveau"></param>
        /// <returns></returns>
        public bool AjouterDocument(Document nouveau)
        {
            if (listeEmprunts.Contains(nouveau) || listeEmprunts.Count >= 4)
            {
                return false;
            }
            else
            {
                listeEmprunts.Add(nouveau);
                return true;
            }
        }
        /// <summary>
        /// Retire un document au membre
        /// </summary>
        /// <param name="retrait"></param>
        /// <returns></returns>
        public bool RetirerDocument(Document retrait)
        {
            if (!listeEmprunts.Contains(retrait))
            {
                return false;
            }
            else
            {
                listeEmprunts.Remove(retrait);
                return true;
            }
        }
    }
}