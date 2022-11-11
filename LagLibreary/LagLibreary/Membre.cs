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
            this.nom = nom;
            List<Document> listeEmprunts = new List<Document>();
            this.noMembre = nbMembresTotal;
            nbMembresTotal++;
        }

        public string GetNom()
        {
            return this.nom;
        }
        public void SetNom(string value)
        {
            this.nom = value;
        }
        public List<Document> GetListeEmprunt()
        {
            return this.listeEmprunts;
        }
        public int GetNbEmprunts()
        {
            return this.listeEmprunts.Count;
        }
        public int GetNoMembre()
        {
            return this.noMembre;
        }
        public bool AjouterDocument(Document nouveau)
        {
            if (listeEmprunts.Contains(nouveau) || listeEmprunts.Count > 4)
            {
                return false;
            }
            else
            {
                listeEmprunts.Add(nouveau);
                return true;
            }
        }
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