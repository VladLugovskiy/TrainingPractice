using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVY_Tusk_07
{
    class Program
    {
        public static void Shuffle<T>(T[] a)
        {
            Random rnd = new Random();

            for (int i = a.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);

                T tmp = a[j];
                a[j] = a[i];
                a[i] = tmp;
            }
        }
        private static void Main(string[] args)
        {
        k:
            try
            {
                Console.WriteLine("How many random numbers will be in the array?");
                int a = Convert.ToInt32(Console.ReadLine());
                int[] b = new int[a];
                Random r = new Random();
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = r.Next(-100, 101);
                }
                Console.Write("Your numbers before the change:  ");
                Console.WriteLine(string.Join(" ", b));
                Shuffle(b);
                Console.Write("Your numbers after the change: ");
                Console.WriteLine(string.Join(" ", b));
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("You entered the wrong data type!" +
                    "\nTry again\n");
                goto k;
            }

        }

    }
}