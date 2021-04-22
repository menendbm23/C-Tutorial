using System;

namespace userImput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.Write("Enter your age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old");


            Console.Write("Do you want the red pill or blue pill: ");
            string decision = Console.ReadLine();
            if (decision == "blue") 
            {
                Console.WriteLine(name + " you didnt make it to the matrix. You're dead");
            } else if (decision == "red") {
                Console.WriteLine("Congratulations " + name + " you made it into the matrix.");
            }




            Console.ReadLine();
        }
    }
}
