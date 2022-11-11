using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    internal class Repertoire
    {
        List<Document> listeDocument;
        string nom;

        public Repertoire(string nomRepertoire, string nomFichier)
        {
            this.nom = nomRepertoire;
            List<Document> listeDocument = new List<Document>();
        }
        public List<Document> GetListeDocument()
        {
            return listeDocument;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public List<Document> GetListeAttente()
        {
            return listeDocument;
        }
        public List<Document> GetListeEmprunts()
        {
            return Membre.listeDocument;
        }
        public Document[] ChargerDocument(string nomFichier)
        {
            //Document[] chargerDocument = new Document[0];
            throw new NotImplementedException();
        }
        public Document[] TrouverDocument(string titre, string nomAuteur)
        {
            throw new NotImplementedException();
        }
        public bool AjouterDocument(Document nouveauDoc)
        {
            throw new NotImplementedException();
        }
        public bool SupprimerDocument(Document docASupprimer)
        {
            throw new NotImplementedException();
        }
        public bool VerifierDDisponibiilite(Document docAVerifier)
        {
            throw new NotImplementedException();
        }


    }
}
