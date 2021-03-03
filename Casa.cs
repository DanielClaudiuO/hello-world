using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    class Casa: Buildings
    {
        Persoana locuitor;
        public Casa (Strada strada, int yearBuilt, int height,Persoana locuitor) : base(strada, yearBuilt, height)
        {
            this.locuitor = locuitor;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
