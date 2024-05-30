using System.Text.RegularExpressions;
using static_extension_HW.Models;

namespace static_extension_HW
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Fullname: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Enter your Email: ");
            string? email = Console.ReadLine();

            string? password = null;
            
            User user1 = new User(fullname, email, password);

            while (true)
            {              
                Console.WriteLine("Password: ");
                password = Console.ReadLine();

                if (user1.PasswordChecker(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("type again");
                }
            }

            User user = new User(password, fullname, email);

            
            Console.WriteLine("1. Show Info");
            Console.WriteLine("2. Create new group");

            string choice = Console.ReadLine();

           
            if (choice == "1")
            {
                user.ShowInfo();
            }
            else if (choice == "2")
            {
                Console.WriteLine("enter group");
                string groupno = Console.ReadLine();
                string studentlimit = Console.ReadLine();

                Group group = new Group(groupno, studentlimit); 

            }
            else
            {
                Console.WriteLine("choose between 1 && 2");
            }
        }
    }
}
