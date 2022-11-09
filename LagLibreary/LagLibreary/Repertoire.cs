using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    internal class Repertoire
    {
        Document[] listeDocument = new Document[0];
        string nom;

        public Repertoire(string nomRepertoire, string nomFichier)
        {
            //this.nom = nomRepertoire;
            //this.nom = nomFichier;
            throw new NotImplementedException();
        }
        public Document[] GetListeDocument()
        {
            return listeDocument;
        }
        public string GetNom()
        {
            return nom;
        }
        public Document[] GetListeAttente()
        {
            Document[] listeAttente = new Document[0];
            return listeAttente;
        }
        public Document[] GetListeEmprunts()
        {
            Document[] listeEmprunts = new Document[0];
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
