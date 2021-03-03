using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    class Masina : Autovehicule
    {
        public Masina(string marca, int productionYear, long kilometers, Persoana owner) : base(marca, productionYear, kilometers, owner)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
