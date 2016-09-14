using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInformation;

namespace UserInformationTests
{
    [TestClass]
    public class UserInfoTests
    {
        private string name;
        private int age;
        private string username;
        private UserInfo info;
        [TestInitialize]
        public void Initialize()
        {
            name = "John";
            age = 11;
            username = "bluewagon";
            info = new UserInfo(name, age, username);
        }

        [TestMethod]
        public void UserInfo_ShouldDisplayCorrectValues()
        {
            Assert.AreEqual($"Your name is {name}, you are {age} years old, and your username is {username}", info.Display());
        }

        [TestMethod]
        public void UserInfo_ShouldReturnValuesForToString()
        {
            Assert.AreEqual($"{name},{age},{username}", info.ToString());
        }
    }
}
