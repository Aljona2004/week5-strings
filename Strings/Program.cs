using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi;");
            string firstName = Console.ReadLine();

            Console.WriteLine(firstName[0]);

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Teie nimi on {firstNameLenght} sümbolit pikk");

            //viimase tähe indeks = firstNameLenght - 1
            Console.WriteLine(firstName[firstNameLenght - 1]);
        }
    }
}
