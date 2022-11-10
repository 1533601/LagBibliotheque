﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    internal class Audio : Document, IDescription
    {
        int nbMinutes;
        string format;

        public Audio (string titre, string auteur,string description,  int nbMinutes, string format) : base(titre, auteur, description)
        {
            this.nbMinutes = nbMinutes;
            this.format = format;
        }
        public int GetNbMinutes()
        {
            return this.nbMinutes;
        }
        public string GetFormat()
        {
            return this.format;
        }
        public string GetDescription()
        {
            return Description();
        }
    }
}
