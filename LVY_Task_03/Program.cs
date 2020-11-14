using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LVY_Task_03
{
    class Program
    {
        public static int t = 2; // попытки
        static void Main(string[] args)
        {
            string RK33 = "RK33"; // правильны пароль
            for (int i = 0; i < 4; i++)
           
            {
                Console.WriteLine("Enter the password: ");
                string password = Console.ReadLine();
                if (password == RK33)
                {
                    goto Finish_good;

                }
                else if (t == 0)
                {
                    goto Finish_bad;
                }
                else
                {
                    Console.WriteLine($"Password is incorrect \n");// выводится на экран, если пароль введен неверно
                    t--;
                }
            }
        Finish_good:
            Console.WriteLine();
            Console.WriteLine("Welcome  \n");// выводится на экран, если пароль введен верно
            Console.ReadKey();
            Environment.Exit(0);

        Finish_bad:
            Console.WriteLine();
            Console.WriteLine("You have exceeded the number of attempts  \n");// выводится на экран, если пароль введен неверно 3 раза
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}