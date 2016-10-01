using Caesar_Cipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipherTests
{
    [TestClass]
    public class CipherTests
    {
        private Cipher _cipher;
        private int _shiftAmount;

        [TestInitialize]
        public void Initialize()
        {
            _shiftAmount = 4;
            _cipher = new Cipher();
        }

        [TestMethod]
        public void Cipher_IsLetter()
        {
            Assert.IsTrue(_cipher.IsLetter('a'));
            Assert.IsTrue(_cipher.IsLetter('A'));
            Assert.IsTrue(_cipher.IsLetter('z'));
            Assert.IsTrue(_cipher.IsLetter('Z'));
            Assert.IsFalse(_cipher.IsLetter('1'));
        }

        [TestMethod]
        public void Cipher_ShiftToRightLower()
        {
            char shifted = _cipher.Shift('a', _shiftAmount);
            Assert.AreEqual('e', shifted);
            shifted = _cipher.Shift('z', _shiftAmount);
            Assert.AreEqual('d', shifted);
            shifted = _cipher.Shift('w', _shiftAmount);
            Assert.AreEqual('a', shifted);
            shifted = _cipher.Shift('x', _shiftAmount);
            Assert.AreEqual('b', shifted);
        }

        [TestMethod]
        public void Cipher_ShiftToRightUpper()
        {
            char shifted = _cipher.Shift('A', _shiftAmount);
            Assert.AreEqual('E', shifted);
            shifted = _cipher.Shift('Z', _shiftAmount);
            Assert.AreEqual('D', shifted);
            shifted = _cipher.Shift('W', _shiftAmount);
            Assert.AreEqual('A', shifted);
            shifted = _cipher.Shift('X', _shiftAmount);
            Assert.AreEqual('B', shifted);
        }

        [TestMethod]
        public void Cipher_ShiftToLeftLower()
        {
            _shiftAmount = -_shiftAmount;
            char shifted = _cipher.Shift('a', _shiftAmount);
            Assert.AreEqual('w', shifted);
            shifted = _cipher.Shift('z', _shiftAmount);
            Assert.AreEqual('v', shifted);
            shifted = _cipher.Shift('c', _shiftAmount);
            Assert.AreEqual('y', shifted);
            shifted = _cipher.Shift('d', _shiftAmount);
            Assert.AreEqual('z', shifted);
        }

        [TestMethod]
        public void Cipher_ShiftToLeftUpper()
        {
            _shiftAmount = -_shiftAmount;
            char shifted = _cipher.Shift('A', _shiftAmount);
            Assert.AreEqual('W', shifted);
            shifted = _cipher.Shift('Z', _shiftAmount);
            Assert.AreEqual('V', shifted);
            shifted = _cipher.Shift('C', _shiftAmount);
            Assert.AreEqual('Y', shifted);
            shifted = _cipher.Shift('D', _shiftAmount);
            Assert.AreEqual('Z', shifted);
        }

        [TestMethod]
        public void Cipher_InvalidCharacters()
        {
            char shifted = _cipher.Shift('@', _shiftAmount);
            Assert.AreEqual('@', shifted);
            shifted = _cipher.Shift(' ', _shiftAmount);
            Assert.AreEqual(' ', shifted);
        }

        [TestMethod]
        public void Cipher_EncryptMessage()
        {
            string message = "This message is encrypted";
            string encrypted_message = "Xlmw qiwweki mw irgvctxih";
            string encrypted = _cipher.Encrypt(message, _shiftAmount);
            Assert.AreEqual(encrypted_message, encrypted);
        }

        [TestMethod]
        public void Cipher_DecryptMessage()
        {
            string message = "This message is encrypted";
            string encrypted_message = _cipher.Encrypt(message, _shiftAmount);
            string decrypted = _cipher.Decrypt(encrypted_message, _shiftAmount);
            Assert.AreEqual(decrypted, message);
        }
    }
}
