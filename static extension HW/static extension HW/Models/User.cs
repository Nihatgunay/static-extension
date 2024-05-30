namespace static_extension_HW.Models
{
    public class User : IAccount
    {
        private string _password;
        private static int _count;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }

        static User()
        {
            _count = 0;
        }

        public User(string password, string fullname, string email)
        {
            _count++;
            Id = _count;
            Password = password;
            FullName = fullname;
            Email = email;
        }

        public bool PasswordChecker(string password)
        {
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                if (password.Length >= 8)
                    if (password.Any(char.IsUpper))
                        if (password.Any(char.IsLower))
                            if (password.Any(char.IsDigit))
                                if (password.Any(char.IsPunctuation))
                                    return true;
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
        }
    }
}