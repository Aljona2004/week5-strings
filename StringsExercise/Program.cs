using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            //programm kuvab konsoolis sõna esimest tähte ja viimast tähte

            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[helloWorld.Length-1]);
        }
    }
}
