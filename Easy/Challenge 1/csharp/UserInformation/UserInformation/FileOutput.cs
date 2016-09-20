using System.IO;

namespace UserInformation
{
    public class FileOutput
    {
        // what do I want it to do..
        // write to a file
        public static void Write(UserInfo info)
        {
            if (info == null)
            {
                return;
            }
            File.AppendAllLines("user_information.csv", new []{ info.ToString() });
        }
    }
}