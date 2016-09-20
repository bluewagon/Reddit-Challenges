using System;

namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo info = new UserInfo();
            ConsoleInput input = new ConsoleInput();
            info.Name = input.GetName();
            info.Age = input.GetAge();
            info.Username = input.GetUsername();
            ConsoleOutput output = new ConsoleOutput();
            output.Write(info);
            FileOutput.Write(info);
            Console.ReadLine();
        }
    }
}
