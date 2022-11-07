using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    internal class Audio : Document, IDescription, IImprime
    {
        int nbMinutes;
        string format;

        public Audio (string titre, string auteur, int nbMinutes, string format) : base(titre, auteur)
        {
            this.nbMinutes = nbMinutes;
            this.format = format;
        }
        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public int GetNbPages()
        {
            throw new NotImplementedException();
        }
    }
}
