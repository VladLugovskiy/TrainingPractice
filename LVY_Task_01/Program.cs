using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVY_Task_01
{

    class Program
    {
        public const int crystal_cost = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("How much gold do you have?: ");
            int Gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1 crystal = {crystal_cost} gold.How many crystals do you need?");
            int crystal = Convert.ToInt32(Console.ReadLine());
            try
            {
                int calculation = Gold - crystal * crystal_cost;
                int[] arr = new int[Gold + 1];
                arr[calculation] = 1;
                Console.WriteLine($"You have {calculation} gold and {crystal} crystals.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"You are too poor, come back later. Here's your gold\n{Gold}.");
                int fail = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            };
        }
    }


}