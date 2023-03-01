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
                      if ((password % 10 != 0) && (password / 10)%10 != 0 && (password / 100)%10 != 0 && (password / 1000)%10 != 0 && (password / 10000)%10 != 0 && (password /100000 != 0))  
                        answered = true;
                    }
                    break;
                case "FBI":
                    if ((password / 100000)%10 >=4 && (password / 100000)%10 <=7 && ((password/100)%10)%2 ==0 && ((password/100)%10) !=6 && ((password/10000)%10) !=0 && ((password/10000)%10) !=2 
                         && ((password/10000)%10) !=4 && ((password/10000)%10) !=6 && ((password/10000)%10) !=8)
                    {
                      if ((password % 10 != 0 ) && ((password / 10) % 10 != 0 ) && ((password / 100) % 10 != 0 )  && 
                          ((password / 1000) % 10 != 0 ) && ((password / 10000) % 10 != 0) && (password / 100000 != 0 ))
                        answered = true;
                    }
                    break;
                case "NSA":
                    if (password % 10 !=4 && password % 10 !=7 && password % 10 !=8 && password % 10 !=9 && password % 10 !=0 && ((password/100)%10)%3 ==0 && (password % 10 == 7 ) 
                        || ((password / 10) % 10 == 7)|| ((password / 100) % 10 == 7) || ((password / 1000) % 10 == 7) || ((password / 10000) % 10 == 7) || (password / 100000 == 7) 
                        )
                    {
                      if ((password % 10 != 0 ) && ((password / 10) % 10 != 0 ) && ((password / 100) % 10 != 0 )  && 
                          ((password / 1000) % 10 != 0 ) && ((password / 10000) % 10 != 0) && (password / 100000 != 0 ))
                        answered = true;
                    }
                    break;
                default:
                    break;

            }
                if (answered)
            {
                Console.WriteLine("Password are corrected.");
            }
            else
            {
                Console.WriteLine("Password are incorrected.");
            }
        }
    }
}