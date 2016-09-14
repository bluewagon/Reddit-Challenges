namespace UserInformation
{
    public class UserInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }

        public UserInfo()
        {
        }

        public UserInfo(string name, int age, string username)
        {
            Name = name;
            Age = age;
            Username = username;
        }

        public string Display()
        {
            return $"Your name is {Name}, you are {Age} years old, and your username is {Username}";
        }

        public override string ToString()
        {
            return $"{Name},{Age},{Username}";
        }
    }
}