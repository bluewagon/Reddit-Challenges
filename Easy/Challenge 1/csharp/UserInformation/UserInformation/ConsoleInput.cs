using System;

namespace UserInformation
{
    public class ConsoleInput
    {
        public string GetName()
        {
            return GetString("Please enter your name: ");
        }

        public int GetAge()
        {
            int age = 0;
            while (age < 1 || age > 99)
            {
                Console.WriteLine("Please enter your age: ");
                var inputAge = Console.ReadLine();
                if (Int32.TryParse(inputAge, out age))
                {
                    if (age < 1 || age > 99)
                    {
                        Console.WriteLine("Age is not valid.");
                    }
                }
                else
                {
                    Console.WriteLine("Please use a number.");
                }
            }
            return age;
        }

        public string GetUsername()
        {
            return GetString("Please enter your username: ");
        }

        private string GetString(string message)
        {
            string item = string.Empty;
            while (string.IsNullOrEmpty(item))
            {
                Console.WriteLine(message);
                item = Console.ReadLine();
            }
            return item;
        }
    }
}