
using System.Globalization;

namespace LagLibreary
{
    public class Bibliotheque
    {
        Repertoire leRepertoire;
        string nom;
        Membre[] lesMembre;

        public Bibliotheque(string nomBiblio, Repertoire leRepertoire)
        {
            this.nom = nomBiblio;
            this.leRepertoire = leRepertoire;
            this.lesMembre = new Membre[100];
        }
        public string GetNom()
        {
            return this.nom;

        }
        public Membre[] GetMembres()
        {
            return this.lesMembre;
        }

        public bool NotifierEmprunt(string nomMembre, Document leDocument)
        {
            bool empruntReussi = false;
            for(int i = 0; i < this.lesMembre.Length; i++)
            {
                if (lesMembre[i] != null)
                {
                    if (lesMembre[i].GetNom() == nomMembre)
                    {
                        empruntReussi = lesMembre[i].AjouterDocument(leDocument);
                        if(empruntReussi == false)
                        {
                            AjouterListeAttente(lesMembre[i], leDocument);
                        }
                    }
                }
            }
            return empruntReussi;
        }
        public bool NotifierRetour(Document leDocument)
        {
            bool retourReussi = false;
            for (int i = 0; i < this.lesMembre.Length; i++)
            {
                for(int j = 0; j > lesMembre[i].GetListeEmprunt().Count; j++)
                {
                    if (lesMembre[i].GetListeEmprunt()[j] != null)
                    {
                        retourReussi = lesMembre[i].RetirerDocument(leDocument);
                    }
                }
            }
            return retourReussi;
        }
        public Membre TrouverMembre(string nom)
        {
            Membre leMembre = null;
            for(int i = 0; i < this.lesMembre.Length; i++)
            {
                if(lesMembre[i] != null)
                {
                    if (lesMembre[i].GetNom() == nom)
                    {
                        leMembre = this.lesMembre[i];
                    }
                }
            }
            if (leMembre == null)
            {
                throw new ReturnValueCannotBeNullException();
            }
            else
            {
                return leMembre;
            }
        }
        public void AjouterMembre(Membre nouveau)
        {
            int i = 0;
            int j = 0;
            do
            {
                i = j;
                if(this.lesMembre[i] == null)
                {
                    this.lesMembre[i] = nouveau;
                }
                i++;
            }
            while(i != this.lesMembre.Length || this.lesMembre[j] == nouveau);
        }
        public bool AjouterListeAttente(Membre leMembre, Document leDoc)
        {
            bool ajoutAccompli = false;
            for(int i = 0; i < this.lesMembre.Length; i++)
            {
                if (lesMembre[i] != null)
                {
                    if (lesMembre[i] == leMembre)
                    {
                        ajoutAccompli = leDoc.AjouterMembreListeAttente(lesMembre[i]);
                    }
                }
            }
            return ajoutAccompli;
        }
    }
}