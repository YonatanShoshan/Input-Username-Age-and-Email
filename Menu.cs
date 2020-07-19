using System;

namespace ConsoleApp2
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            Console.WriteLine("Email is: " + Email);
            //Initialize age in the scope that we want to use it
            int age;
            //Loop until we have a valid number
            do
            {
                Console.WriteLine("Enter your age:");
                string ageInput = Console.ReadLine();
            } while (!int.TryParse(ageInput, out age));











        }
    }
}
