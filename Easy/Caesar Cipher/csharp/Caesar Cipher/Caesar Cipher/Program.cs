using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            Console.Write("Insert message to encrypt: ");
            message = Console.ReadLine();
            Cipher cipher = new Cipher();
            string encryptedMessage = cipher.Encrypt(message, 13);
            Console.WriteLine($"Encrypted message: {encryptedMessage}");
            Console.ReadLine();
        }
    }
}
