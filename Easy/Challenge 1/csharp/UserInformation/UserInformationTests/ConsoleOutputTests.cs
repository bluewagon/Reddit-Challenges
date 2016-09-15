using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInformation;

namespace UserInformationTests
{
    [TestClass]
    public class ConsoleOutputTests
    {
        private UserInfo info;

        [TestInitialize]
        public void Initialize()
        {
            info = new UserInfo()
            {
                Age = 22,
                Name = "Bob",
                Username = "bluewagon",
            };   
        }

        [TestMethod]
        public void ConsoleOutput_ShouldDisplayMessage()
        {

            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                ConsoleOutput output = new ConsoleOutput();
                output.Write(info);

                Assert.AreEqual(info.Display() + Environment.NewLine, writer.ToString());
            }
        }

        [TestMethod]
        public void ConsoleOutput_ShouldDoNothingIfNull()
        {
            using (StringWriter writer = new StringWriter())
            {
                info = null;
                Console.SetOut(writer);
                ConsoleOutput output = new ConsoleOutput();
                output.Write(info);

                Assert.AreEqual(Environment.NewLine, writer.ToString());
            }
        }
    }
}