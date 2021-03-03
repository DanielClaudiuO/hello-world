using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    class Strada
    {
        private string nume { set; get; }
        private string categorie { set; get; }
        private int lungime { set; get; }

        public Strada(string nume, string categorie, int lungime)
        {
            this.nume = nume;
            this.categorie = categorie;
            this.lungime = lungime;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
