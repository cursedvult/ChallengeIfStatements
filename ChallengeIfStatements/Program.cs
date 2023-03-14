using System;

namespace ChallengeIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = UserName();
            string userPwd = PWD();
            Login(userName, userPwd);
        }
        public static string UserName()
        {
            Console.WriteLine("Register here!");
            Console.WriteLine("Enter your desired username");
            string userName = Console.ReadLine();
            Console.Clear();
            return userName.Trim();
            
        }
        public static string PWD()
        {
            Console.WriteLine("Enter your desired password");
            string userPwd = Console.ReadLine();
            Console.WriteLine("Register successful");
            Console.Clear();
            return userPwd.Trim();
        }
        public static void Login(string userName, string userPwd)
        {
            Console.WriteLine("Enter your username");
            string userTryName = Console.ReadLine();
            if (userTryName == userName)
            {
                Console.WriteLine($"Welcome {userTryName}. Please insert your password:");
                string userTryPwd = Console.ReadLine();
                if (userTryPwd == userPwd) 
                {
                    Console.WriteLine("You are logged in.");
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                }
            }else
            {
                Console.WriteLine("User not valid");
            }
        }
    }
}
