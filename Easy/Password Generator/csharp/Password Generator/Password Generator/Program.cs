using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            bool passwordCreated = false;

            while (!passwordCreated)
            {
                Console.WriteLine("Insert how long the password should be: ");
                string inputLength = Console.ReadLine();
                int length;
                if (Int32.TryParse(inputLength, out length) && length > 0)
                {
                    string password = generator.Generate(length);
                    Console.WriteLine($"Your password is {password}");
                    passwordCreated = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number that is greater than zero.");
                }
            }

            Console.ReadLine();
        }
    }
}
