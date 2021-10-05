using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada eesnime ja perekonnanime
            //programm võrdleb sisetatud andmeid oma vahel
            //programm kuvab konsoolis, kumb on pikem-eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma nimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("eesnimi on pikem kui perekonnanimi");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("perekonnanimi on pikem kui eesnimi");
            }
        }
    }
}
