using System;

namespace UserInformation
{
    public class ConsoleOutput
    {
        public void Write(UserInfo info)
        {
            Console.WriteLine(info?.Display());
        }
    }
}