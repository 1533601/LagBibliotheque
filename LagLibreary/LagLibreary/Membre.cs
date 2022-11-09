using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class Membre
    {
        string nom;
        Document[] listeEmprunts = new Document[0];
        int noMembre;
        static int nbMembresTotal;

        public string GetNom()
        {
            throw new NotImplementedException();
        }
        public void SetNom(string value)
        {
            throw new NotImplementedException();
        }
        public Document[] GetListeEmprunt()
        {
            throw new NotImplementedException();
            //return listeEmprunts;
        }
        public int GetNbEmprunts()
        {
            throw new NotImplementedException();
        }
        public int GetNoMembre()
        {
            throw new NotImplementedException();
        }
        public Membre(string nom)
        {
            throw new NotImplementedException();
        }
        public bool AjouterDocument(Document nouveau)
        {
            throw new NotImplementedException();
        }
        public bool RetirerDocument(Document retrait)
        {
            throw new NotImplementedException();
        }
    }
}