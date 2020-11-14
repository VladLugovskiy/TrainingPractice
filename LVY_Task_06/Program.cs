using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LVY_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] fio = new string[3][];
            fio[0] = new string[100];
            fio[1] = new string[100];
            fio[2] = new string[100];

            string[] dolzh = new string[100];
            int i = 0;
            bool isNeeded = true; // Проверка 
            do
            {
                Console.Write("Personnel department: " +
                           "\n  1. add a dossier " +
                           "\n  2. display all dossiers" +
                           "\n  3. delete a dossier" +
                           "\n  4. search by surname" +
                           "\n  5. exit the program \n \n");
                Console.Write("Select menu item: ");

                int function;
                try { function = Convert.ToInt32(Console.ReadLine()); }
                catch { function = 0; }
                Console.Clear();
                switch (function)
                {
                    case 1:

                        Console.Write("Enter your surname: ");
                        fio[0][i] = Console.ReadLine();
                        Console.Write("Enter your name: ");
                        fio[1][i] = Console.ReadLine();
                        Console.Write("Enter your middle name: ");
                        fio[2][i] = Console.ReadLine();

                        Console.Write("Enter your position: "); // данные человека
                        dolzh[i] = Console.ReadLine();
                        i++; 
                        Console.Write("The data was entered successfully. Press any key...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        if (i != 0)
                        {

                            Console.Clear();
                            Console.WriteLine("The conclusion of all dossiers: \n");
                            for (int j = 0; j <= i - 1; j++)
                            {
                                Console.WriteLine($"{j}. {fio[0][j]} {fio[1][j]} {fio[2][j]} - {dolzh[j]}"); // Выводим данные
                            }
                            Console.Write("\n Press any key...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {

                            Console.Write("No records found. Click any button to continue!");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;

                    case 3:

                        Console.Write("Enter the number of the dossier to delete: ");
                        int choice;
                    again:
                        try { choice = Convert.ToInt32(Console.ReadLine()); }
                        catch { goto again; }

                        bool isFounded = false;
                        if (choice <= i && choice > 0)
                        {

                            for (int j = 0; j <= i; j++)
                            {

                                if (j == choice || isFounded)
                                {

                                    if (j != i - 1)
                                    {

                                        fio[0][j] = fio[0][j + 1];
                                        fio[1][j] = fio[1][j + 1];
                                        fio[2][j] = fio[2][j + 1];
                                        dolzh[j] = dolzh[j + 1];
                                        isFounded = true;

                                    }
                                    else
                                    {

                                        fio[0][j] = "";
                                        fio[1][j] = "";
                                        fio[2][j] = "";
                                        dolzh[j] = "";

                                    }
                                }
                            }
                            i--;
                            Console.WriteLine("The dossier was deleted successfully. Press any key...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("There is no dossier with this number. Press any key...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 4:

                        Console.Write("Enter your surname to search for: ");
                        string surname = Console.ReadLine(); // Ввод фамилии
                        bool isAtLeastOne = false; 

                        for (int j = 0; j <= i; j++)
                        {
                            if (surname == fio[0][j])
                            {
                                isAtLeastOne = true;
                                Console.WriteLine($"{j}. {fio[0][j]} {fio[1][j]} {fio[2][j]} : {dolzh[j]}");
                            }
                        }
                        if (!isAtLeastOne)
                        {

                            Console.WriteLine("There are no employees with this surnname");

                        }
                        Console.WriteLine("\n Press any key...");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 5:

                        isNeeded = false;
                        break;
                    default:
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (isNeeded);
        }
    }
}