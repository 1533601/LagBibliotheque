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
        /// <summary>
        /// retourne la liste de document du repertoire
        /// </summary>
        /// <returns></returns>
        public List<Document> GetListeDocument()
        {
            return listeDocument;
        }
        /// <summary>
        /// retourne le nom du repertoire
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return this.nom;
        }
        /// <summary>
        /// retourne la de document possèdant une liste d'attente
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// retourne les document qui ne sont pas disponible
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Charger un document selon un fichier texte
        /// </summary>
        /// <param name="nomFichier"></param>
        /// <returns></returns>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="DocumentFormatIncorrectException"></exception>
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
                        if (information.Length == 7)
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
                        if (information.Length == 6)
                        {
                            Audio nouveauAudio = new Audio(information[1], information[2], information[3], listeAttente, int.Parse(information[4]), information[5]);
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
        /// <summary>
        /// Trouve un document, si le document n'est pas trouvé, retourne un exception
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="nomAuteur"></param>
        /// <returns></returns>
        /// <exception cref="ReturnValueCannotBeNullException"></exception>
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
        /// <summary>
        /// Ajoute un document au repertoire
        /// </summary>
        /// <param name="nouveauDoc"></param>
        /// <returns></returns>
        public bool AjouterDocument(Document nouveauDoc)
        {
            this.listeDocument.Add(nouveauDoc);
            return true;
        }
        /// <summary>
        /// Supprime un document du repertoire
        /// </summary>
        /// <param name="docASupprimer"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Vérifie si un document est disponible
        /// </summary>
        /// <param name="docAVerifier"></param>
        /// <returns></returns>
        public bool VerifierDisponibiilite(Document docAVerifier)
        {
            return docAVerifier.EstDisponible();
        }
    }
}
