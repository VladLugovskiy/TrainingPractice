using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVY_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word: ");
            string word = " ";
            do
            {
                word = Console.ReadLine();
            }
            while (word != ("exit"));
            Console.WriteLine("The program has finished working. ");
        }
    }
}