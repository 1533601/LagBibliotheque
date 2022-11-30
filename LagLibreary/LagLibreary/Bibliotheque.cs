
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
                        if (leDocument.GetEmprunteur() == null)
                        {
                            leDocument.SetEmprunteur(lesMembre[i]);
                            lesMembre[i].AjouterDocument(leDocument);
                            empruntReussi = true;
                        }
                        else
                        {
                            leDocument.AjouterMembreListeAttente(lesMembre[i]);
                        }
                    }
                }
            }
            return empruntReussi;
        }
        public bool NotifierRetour(Document leDocument)
        {
            bool retourReussi = false;
            bool membreRetirer = false;
            for (int i = 0; i < this.lesMembre.Length; i++)
            {
                if (lesMembre[i] != null)
                {
                    if (leDocument.GetEmprunteur() == lesMembre[i])
                    {
                        if (lesMembre[i].GetListeEmprunt().Contains(leDocument))
                        {
                            if (leDocument.GetListeAttente().Count() == 0)
                            {
                                if (membreRetirer == false)
                                {
                                    lesMembre[i].RetirerDocument(leDocument);
                                    leDocument.SetEmprunteur(null);
                                    retourReussi = true;
                                }
                            }
                            else
                            {
                                lesMembre[i].RetirerDocument(leDocument);
                                leDocument.SetEmprunteur(leDocument.GetListeAttente().First());
                                leDocument.GetListeAttente().First().AjouterDocument(leDocument);
                                leDocument.EnleverMembreListeAttente(leDocument.GetListeAttente().First());
                                membreRetirer = true;
                            }
                        }
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
            bool aAjouter = false;
            do
            {
                if (this.lesMembre[i] == null || lesMembre.Contains(nouveau))
                {
                    this.lesMembre[i] = nouveau;
                    aAjouter = true;
                }
                i++;
            }
            while (aAjouter == false && i < lesMembre.Length) ;
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