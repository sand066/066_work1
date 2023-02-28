using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 6 password your company : ");
            int password = int.Parse(Console.ReadLine());

            Console.Write("Enter your company (CIA, FBI, or NSA): ");
            string company = Console.ReadLine();
            bool answered = false;
            
            switch (company)
            {
                case "CIA":

                    if ((password % 10)%3 == 0 && (password / 10 )%10 !=1 && (password / 10 )%10 !=3 && (password / 10 )%10 !=5
                    && (password / 1000 )%10 >=6 && (password / 1000 )%10 !=8)

                    {
                        answered = true;
                    }
                    break;
            }
        if (answered)
            {
                Console.WriteLine("Your password is corrected.");
            }
            else
            {
                Console.WriteLine("Password is incorrected.");
            }
        }
    }
}