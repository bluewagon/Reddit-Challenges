using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Password_Generator
{
    public class Generator
    {
        private readonly string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private readonly int _charactersLength;
        private static Random _random;

        public Generator()
        {
            _charactersLength = _characters.Length;
            _random = new Random();
        }

        public string Generate(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(_characters[_random.Next(0, _charactersLength)]);
            }

            return sb.ToString();
        }
    }
}
