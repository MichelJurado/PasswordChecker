//Michel Jurado

using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            //determines strength of a password

            //variables
            int minLength = 8;
            string uppercase = "A,B,C,DE,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0,1,2,3,4,5,6,7,8,9";
            string specialChars = "!@#$%^&*";

            Console.WriteLine("Enter a password");

            string password = Console.ReadLine();

            int score = 0;
            int passwordLength = password.Length;


            // loops for booleans 
            //need to use loops for contains to iterate through the string

            bool hasSpecialChars = false;
            //string = char[]
            foreach (char i in specialChars)
            {
                if (password.Contains(i))
                {
                    hasSpecialChars = true;
                    break;
                }
            };

            bool hasUppercase = false;
            foreach (char i in uppercase)
            {
                if (password.Contains(i))
                {
                    hasUppercase = true;
                    break;
                }
            };

            bool hasLowercase = false;
            foreach (char i in lowercase)
            {
                if (password.Contains(i))
                {
                    hasLowercase = true;
                    break;
                }
            };

            bool hasDigits = false;
            foreach (char i in digits)
            {
                if (password.Contains(i))
                {
                    hasDigits = true;
                    break;
                }
            };

            Console.WriteLine(hasSpecialChars);
            

  

            if (passwordLength >= minLength)
            {
                score++;
            }

            if (hasSpecialChars)
            {
                score++;
            }

            if (hasUppercase)
            {
                score++;
            }

            if (hasLowercase)
            {
                score++;
            }
            if (hasDigits)
            {
                score++;
            }





            Console.WriteLine(score);




            switch (score)
            {
                case 5:
                    Console.WriteLine("For scores of 4 and 5, the password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("For scores of 4 and 5, the password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("For scores of 3, the password is strong");
                    break;
                case 2:
                    Console.WriteLine("For scores of 2, the password is medium");
                    break;
                case 1:
                    Console.WriteLine("For scores of 1, the password is weak");
                    break;
                default:
                    Console.WriteLine("The password doesn't meent any of the standards");
                    break;
            }
            

        }
    }
}
