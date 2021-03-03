using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    abstract class Buildings
    {
        Strada strada;
        int YearBuilt;
        int height;

        public Buildings(Strada strada, int yearBuilt, int height)
        {
            this.strada = strada;
            YearBuilt = yearBuilt;
            this.height = height;
        }
    }
}
