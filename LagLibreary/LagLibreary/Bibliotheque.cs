
namespace LagLibreary
{
    public class Bibliotheque
    {
        Repertoire leRepertoire;
        string nom;
        Membre[] lesMembre;

        public Bibliotheque(string nomBiblio)
        {
            this.nom = nomBiblio;
            this.lesMembre = new Membre[0];
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
            throw new NotImplementedException();
        }
        public bool NotifierRetour(Document leDocument)
        {
            throw new NotImplementedException();
        }
        public Membre TrouverMembre(string nom)
        {
            throw new NotImplementedException();
        }
        public void AjouterMembre(Membre nouveau)
        {
            this.lesMembre[0] = nouveau;
            this.lesMembre[1] = nouveau;
        }
        public bool AjouterListeAttente(Membre leMembre, Document leDoc)
        {
            throw new NotImplementedException();
        }
    }


}