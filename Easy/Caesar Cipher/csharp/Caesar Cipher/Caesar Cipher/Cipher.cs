namespace Caesar_Cipher
{
    public class Cipher
    {
        private int _z = 'z';
        private int _Z = 'Z';
        private int _a = 'a';
        private int _A = 'A';

        public string Encrypt(string message, int shiftAmount)
        {
            char[] encryptedMessage = message.ToCharArray();
            for (int i = 0; i < message.Length; i++)
            {
                encryptedMessage[i] = Shift(message[i], shiftAmount);
            }
            return new string(encryptedMessage);
        }

        public string Decrypt(string message, int shiftAmount)
        {
            char[] encryptedMessage = message.ToCharArray();
            for (int i = 0; i < message.Length; i++)
            {
                encryptedMessage[i] = Shift(message[i], -shiftAmount);
            }
            return new string(encryptedMessage);
        }

        public bool IsLetter(char character)
        {
            // not using char.IsLetter because it will return true for other unicode letters
            int upperValue = char.ToUpper(character);
            return upperValue >= (int) 'A' && upperValue <= (int) 'Z';
        }

        public char Shift(char character, int shiftAmount)
        {
            if (!IsLetter(character))
            {
                return character;
            }
            bool lower = char.IsLower(character);
            char shifted = (char) (character + shiftAmount);
            if (!IsLetter(shifted))
            {
                int remainingShift;
                int beginning;
                bool shiftRight = (shiftAmount > 0);
                if (lower)
                {
                    remainingShift = shiftRight ? (_z - character) : character - _a;
                    beginning = shiftRight ? _a - 1 : _z + 1;
                }
                else
                {
                    remainingShift = shiftRight ? _Z - character : character - _A;
                    beginning = shiftRight ? _A - 1: _Z + 1;
                }
                remainingShift = shiftRight ? shiftAmount - remainingShift : shiftAmount + remainingShift;
                shifted = (char)(beginning + remainingShift);
            }
            return shifted;
            
        }
    }
}