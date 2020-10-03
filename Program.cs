//Author: Elliot Vasquez
//This C# console will exercise user input. Go Bulls \m/

using System;

namespace HelloUserName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable used to store string value
            string name;

            //Display message
            Console.WriteLine("Please enter your name");

            //Holds the value that was input by user
            name = Console.ReadLine();

            //Display Output
            Console.WriteLine("Welcome {0} GO USF BULLS!", name);
        }
    }
}
