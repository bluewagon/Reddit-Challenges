using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Password_Generator;

namespace GeneratorTests
{
    [TestClass]
    public class GeneratorTests
    {
        Generator _generator = new Generator();
        
        [TestMethod]
        public void Generator_ShouldReturnPassword_Length10()
        {
            string password = _generator.Generate(10);
            Assert.AreEqual(10, password.Length);
        }
    }
}
