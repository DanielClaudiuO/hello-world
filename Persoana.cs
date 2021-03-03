using System;
using System.Collections.Generic;
using System.Text;

namespace Oras
{
    class Persoana
    {
        public string nume { get; set; }
        public byte age { get; set; }
        char gender;

        public Persoana(string nume, byte age, char gender)
        {
            this.nume = nume;
            this.age = age;
            this.gender = gender;
        }
    }
}
