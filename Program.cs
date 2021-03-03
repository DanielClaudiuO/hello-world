using System;

namespace Oras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persoana p1 = new Persoana("Daniel", 19, 'M');
            Persoana p2 = new Persoana("Oanta", 18, 'M');
            Persoana p3 = new Persoana("Claudia", 20, 'F');
            Strada s1 = new Strada("Strada", "judetean", 100);
            Casa c1 = new Casa(s1, 2000, 100, p1);
            Autovehicule a1 = new Masina("BMW", 2014, 20000, p1);
            Console.WriteLine(a1);
            Console.WriteLine(c1);
        }
    }
}
