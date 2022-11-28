using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
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
            this.listeDocument = new List<Document>();
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
            for(int i = 0; i < listeEmprunts.Count; i++)
            {
                if (listeEmprunts[i].GetListeAttente().Count <= 1)
                {
                    listeAttente.Add(listeEmprunts[i]);
                }
            }
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
        public List<Document> ChargerDocument(string nomFichier)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"" + nomFichier + ".txt"))
                {
                    string line;
                    string[] colonne;
                    string[] information = null;
                    List<Membre> listeAttente = new List<Membre> ();
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        colonne = line.Split(',');
                        if (i >= 0)
                        {
                            information = colonne;
                        }
                    }
                    if (information[0] == "1")
                    {
                        if (information.Length == 11)
                        {
                            Livre nouveauLivre = new Livre(information[1], information[2], information[3], information[4], listeAttente, new DateTime(int.Parse(information[5]), int.Parse(information[6]), int.Parse(information[7])), int.Parse(information[8]), information[9], information[10]);
                            this.listeDocument.Add(nouveauLivre);
                        }
                        else
                        {
                            throw new DocumentFormatIncorrectException();
                        }
                    }
                    else if (information[0] == "2")
                    {
                        if (information.Length == 8)
                        {
                            Periodique nouveauPeriodique = new Periodique(information[1], information[2], information[3], listeAttente, int.Parse(information[4]), int.Parse(information[5]), int.Parse(information[6]));
                            this.listeDocument.Add(nouveauPeriodique);
                        }
                        else
                        {
                            throw new DocumentFormatIncorrectException();
                        }
                    }
                    else if (information[0] == "3")
                    {
                        if (information.Length == 7)
                        {
                            Audio nouveauAudio = new Audio(information[1], information[2], information[3], listeAttente, int.Parse(information[4]), information[6]);
                            this.listeDocument.Add(nouveauAudio);
                        }
                        else
                        {
                            throw new DocumentFormatIncorrectException();
                        }
                    }
                    else
                    {
                        throw new DocumentFormatIncorrectException();
                    }
                    return this.listeDocument;
                }
            }
            catch (OutOfMemoryException)
            {
                throw new OutOfMemoryException();
            }
            catch (IOException)
            {
                throw new IOException();
            }
            catch (DocumentFormatIncorrectException)
            {
                throw new DocumentFormatIncorrectException();
            }

        }
        public Document TrouverDocument(string titre, string nomAuteur)
        {
            Document document = null;
            for (int i = 0; i < this.listeDocument.Count; i++)
            {
                if (this.listeDocument[i].GetTitre() == titre)
                {
                    if (this.listeDocument[i].GetAuteur() == nomAuteur)
                    {
                        document =  listeDocument[i];
                    }
                }
            }
            if (document == null)
            {
                throw new ReturnValueCannotBeNullException();
            }
            else
            {
                return document;
            }
        }
        public bool AjouterDocument(Document nouveauDoc)
        {
            this.listeDocument.Add(nouveauDoc);
            return true;
        }
        public bool SupprimerDocument(Document docASupprimer)
        {
            bool siDocSupprimer = false;
            for(int i = 0; i < this.listeDocument.Count; i++)
            {
                if (this.listeDocument[i] == docASupprimer)
                {
                    this.listeDocument.Remove(docASupprimer);
                    siDocSupprimer = true;
                }
            }
            return siDocSupprimer;
        }
        public bool VerifierDDisponibiilite(Document docAVerifier)
        {
            return docAVerifier.EstDisponible();
        }
    }
}
