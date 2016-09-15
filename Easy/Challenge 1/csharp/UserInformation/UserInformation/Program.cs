using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.ReadLine();
        }
    }
}
