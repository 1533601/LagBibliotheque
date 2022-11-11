using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;

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
        }
        public string GetNom()
        {
            throw new NotImplementedException();

        }
        public Membre[] GetMembres()
        {
            throw new NotImplementedException();
        }

        public bool NotifierEmprunt(string nomMembre, Document leDocument)
        {
            throw new NotImplementedException();
        }
        public Membre TrouverMembre()
        {
            throw new NotImplementedException();
        }
        public void AjouterMembre()
        {
            throw new NotImplementedException();
        }
        public bool AjouterListeAttente(Membre leMembre, Document leDoc)
        {
            throw new NotImplementedException();
        }
    }


}