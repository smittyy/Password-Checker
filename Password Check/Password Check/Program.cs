using System;

namespace PasswordChecker
{
    public class Program
    {
        static int minLength = 8;
        static string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowercase = "abcdefghijklmnopqrstuvwxyz";
        static string digits = "0123456789";
        static string specialChars = "!@#$%^&*()";
        static int score = 0;

        public static void Main(string[] args)
        {


            Console.WriteLine("Please enter a password.");
            string password = Console.ReadLine();
            int passwordLength = password.Length;

            if (passwordLength >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 1:
                    Console.WriteLine("Your password is really weak");
                    break;
                case 2:
                    Console.WriteLine("Your password is weak");
                    break;
                case 3:
                    Console.WriteLine("Your password is alright");
                    break;
                case 4:
                    Console.WriteLine("Your password is strong");
                    break;
                case 5:
                    Console.WriteLine("your password is really strong");
                    break;
                default:
                    Console.WriteLine("WHAT ON GODS GREEN EARTH DID YOU DO THIS IS THE WORST PASSWORD THAT I HAVE EVER SEEN. MOST PEOPLE CANT DO SO BAD AS TO GET 1, AND YOU GOT NONE");
                    break;
            }

            Console.WriteLine(score);
        }
    }
}