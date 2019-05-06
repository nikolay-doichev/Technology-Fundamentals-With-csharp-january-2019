using System;

namespace _04._Password_Validator
{
    class Program
    {

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool IsBetweenSixAndTenCharas = PasswordLenght(password);
            bool IsLeterAndDigits = PasswordLeterAndDigits(password);
            bool DigitCounter = PasswordConsistingTwoDigit(password);


            if (!IsBetweenSixAndTenCharas)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsLeterAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!DigitCounter)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsBetweenSixAndTenCharas &&
                        IsLeterAndDigits &&
                        DigitCounter)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool PasswordLeterAndDigits(string password)
        {
            for (int index = 0; index < password.Length; index++)
            {
                if (!char.IsLetterOrDigit(password[index]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool PasswordConsistingTwoDigit(string password)
        {
            int count = 0;
            for (int index = 0; index < password.Length; index++)
            {
                if (char.IsDigit(password[index]))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool PasswordLenght(string passward)
        {
            if (passward.Length >= 6 && passward.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
