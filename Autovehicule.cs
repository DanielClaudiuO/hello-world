using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    abstract class Autovehicule
    {
        string marca;
        int productionYear;
        long kilometers;
        Polution polutionLevel;
        Persoana owner;

        public Autovehicule(string marca, int productionYear, long kilometers, Persoana owner)
        {
            this.marca = marca;
            this.productionYear = productionYear;
            this.kilometers = kilometers;
            this.owner = owner;

            if (productionYear < 1996) { polutionLevel = Polution.Euro1; }
            else if(productionYear<2000 && productionYear > 1996) { polutionLevel = Polution.Euro2; }
            else if (productionYear < 2005 && productionYear > 2000) { polutionLevel = Polution.Euro3; }
            else if (productionYear < 2009 && productionYear > 2005) { polutionLevel = Polution.Euro4; }
            else if (productionYear < 2014 && productionYear > 2009) { polutionLevel = Polution.Euro5; }
            else if (productionYear >2014) { polutionLevel = Polution.Euro6; }


        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
