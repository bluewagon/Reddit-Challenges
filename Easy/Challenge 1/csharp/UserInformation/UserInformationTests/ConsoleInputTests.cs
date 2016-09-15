using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInformation;

namespace UserInformationTests
{
    [TestClass]
    public class ConsoleInputTests
    {
        private ConsoleInput _consoleInput;
        private string _name;
        private int _age;
        private string _username;

        [TestInitialize]
        public void Initialize()
        {
            _consoleInput = new ConsoleInput();
            _name = "John";
            _age = 24;
            _username = "bluewagon";
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForNameOnce()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{_name}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    string inputName = _consoleInput.GetName();
                    Assert.AreEqual(_name, inputName);

                    string output = writer.ToString();
                    string expected = $"Please enter your name: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskAgainIfNameIsEmpty()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{string.Empty}{Environment.NewLine}{_name}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    string inputName = _consoleInput.GetName();
                    Assert.AreEqual(_name, inputName);

                    string output = writer.ToString();
                    string expected = $"Please enter your name: Please enter your name: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForAgeOnce()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{_age}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    int inputAge = _consoleInput.GetAge();
                    Assert.AreEqual(_age, inputAge);

                    string output = writer.ToString();
                    string expected = $"Please enter your age: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForAgeAgainIfNull()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{string.Empty}{Environment.NewLine}{_age}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    int inputAge = _consoleInput.GetAge();
                    Assert.AreEqual(_age, inputAge);

                    string output = writer.ToString();
                    string expected = $"Please enter your age: Please use a number." +
                                      $"{Environment.NewLine}Please enter your age: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForAgeAgainIfLessThanOne()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"0{Environment.NewLine}{_age}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    int inputAge = _consoleInput.GetAge();
                    Assert.AreEqual(_age, inputAge);

                    string output = writer.ToString();
                    string expected = $"Please enter your age: Age is not valid." +
                                      $"{Environment.NewLine}Please enter your age: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForAgeAgainIfGreaterThan100()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"100{Environment.NewLine}{_age}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    int inputAge = _consoleInput.GetAge();
                    Assert.AreEqual(_age, inputAge);

                    string output = writer.ToString();
                    string expected = $"Please enter your age: Age is not valid." +
                                      $"{Environment.NewLine}Please enter your age: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskForUsernameOnce()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{_username}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    string inputUsername = _consoleInput.GetUsername();
                    Assert.AreEqual(_username, inputUsername);

                    string output = writer.ToString();
                    string expected = $"Please enter your username: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }

        [TestMethod]
        public void ConsoleInput_ShouldAskAgainIfUsernameIsEmpty()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                using (StringReader reader = new StringReader($"{string.Empty}{Environment.NewLine}{_username}{Environment.NewLine}"))
                {
                    Console.SetIn(reader);

                    string inputUsername = _consoleInput.GetUsername();
                    Assert.AreEqual(_username, inputUsername);

                    string output = writer.ToString();
                    string expected = $"Please enter your username: Please enter your username: ";
                    Assert.AreEqual(expected, output);
                }
            }
        }
    }
}