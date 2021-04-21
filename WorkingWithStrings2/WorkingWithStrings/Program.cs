using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine( phrase.Substring(8, 3) );



            Console.ReadLine();
        }
    }
}
