using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Repertoire
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
            List<Document> listeAttente = new List<Document>();
            List<Document> listeEmprunts = GetListeEmprunts();
            return listeAttente;
        }
        public List<Document> GetListeEmprunts()
        {
            List<Document> listeEmprunts = new List<Document>();
            for (int i = 0; i < this.listeDocument.Count; i++)
            {
                if(this.listeDocument[i].EstDisponible() == false)
                {
                    listeEmprunts.Add(this.listeDocument[i]);
                }
            }
            return listeEmprunts;
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
