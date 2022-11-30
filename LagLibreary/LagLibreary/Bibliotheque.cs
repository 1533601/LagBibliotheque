
using System.Globalization;

namespace LagLibreary
{
    public class Bibliotheque
    {
        string nom;
        Membre[] lesMembre;
        Repertoire leRepertoire;

        public Bibliotheque(string nomBiblio)
        {
            this.nom = nomBiblio;
            this.lesMembre = new Membre[100];
        }
        /// <summary>
        /// Retourne le nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return this.nom;

        }
        /// <summary>
        /// retourne le tableau de membre
        /// </summary>
        /// <returns></returns>
        public Membre[] GetMembres()
        {
            return this.lesMembre;
        }
        /// <summary>
        /// Notification de l'emprunt du livre selon le nom du membre, si le membre existe dans la listes des membres de la bibliothèque, il deviendra l'emprunteur du livre sinon si le livre est déjà emprunter, il sera dans liste d'attente pour obtention du livre
        /// </summary>
        /// <param name="nomMembre"></param>
        /// <param name="leDocument"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Notification du retour du livre et remise de emprunteur a Null
        /// </summary>
        /// <param name="leDocument"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Trouver un membre selon son nom, si il ne le trouve pas retourne un exception car la la membre n'est pas trouvé dans le tableau de membre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        /// <exception cref="ReturnValueCannotBeNullException"></exception>
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
        /// <summary>
        /// Ajouter un membre à la bibliothèque si le membre n'est pas un doublon ou bien le tableau est complet
        /// </summary>
        /// <param name="nouveau"></param>
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
        /// <summary>
        /// Ajoute un membre à liste d'attente 
        /// </summary>
        /// <param name="leMembre"></param>
        /// <param name="leDoc"></param>
        /// <returns></returns>
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