using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVY_Task_04
{

    class Progaram
    {
        static void Main(string[] args)
        {
            Random HpP = new Random();
            Random HpB = new Random();

            int HpPlayer = HpP.Next(250, 500); // здоровье Игрока
            int HpBoss = HpB.Next(400, 900);  // здоровье Босса
            int UltimateDamage = 0; 
            bool Attack = false;

            Random bsd = new Random(); // урон босса 
            Random hlp = new Random(); // здоровье
            Random kam = new Random(); // оглушение от валуна

            Console.WriteLine("You are a shadow mage. Now you have to defeat the Boss.\n");
            Console.WriteLine("The boss deals damage in the range of 10 to 80 units. \n");
            Console.WriteLine("Your attack takes place after the attack of the Boss \n");

            do
            {
            chooseAgain:
                Console.WriteLine($"Your HP: {HpPlayer}");
                Console.WriteLine($"Boss HP: {HpBoss}\n");
                Console.Write("Select a spell: \n" +

                "1.Fire ball (50 damage) \n" +
                "2.Water jet (with a 50% chance knocks the Boss off balance, when triggered, you get a treatment (100), if the health is lower than 250) \n" +
                "3.Flying boulder(Deals 100 damage and 50% chance to stun the boss for 1 turn) \n" +
                "4.You can summon a shadow That will deal 100 damage, for this you need to repeat this spell 3 times \n" +
                "5.Makes the Shadow attack the boss(100 damage)  \n");

                int spell = 0;
                try { spell = Convert.ToInt32(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("You entered the wrong data type.");
                    goto chooseAgain;
                }
                Console.Clear();
                int BossDamage = bsd.Next(10, 80); // случайны урон босса за ход
                int chanseHelp = hlp.Next(0, 2);  // срабатывание заклинания 
                int stun = kam.Next(0, 2); // пропуск хода босса
                switch (spell) 
                {
                    case (1):
                        HpBoss -= 50;
                        break;
                    case (2):
                        if (chanseHelp == 1 && Attack == true)
                        {
                            Console.WriteLine("You've thrown the Boss off balance");
                            BossDamage = 0;
                            if (HpPlayer < 250)
                            {
                                HpPlayer += 100;
                            }
                        }
                        break;
                    case (3):
                        if (stun == 1)
                        {
                            Console.WriteLine("The boss is stunned\n");
                            BossDamage = 0;
                        }
                        HpBoss -= 100;
                        break;
                    case (4): 
                        UltimateDamage = UltimateDamage + 1;

                        if (UltimateDamage > 3)
                        {
                            Console.WriteLine("The shadow is already called, you miss the move!");
                        }
                        if (UltimateDamage == 3)
                        {
                            Console.WriteLine("You summoned a shadow and It dealt 100 points of damage to the Boss!\n");
                            HpBoss -= 100;
                        }
                        break;
                    case (5):
                        HpBoss -= 100;
                        break;
                    default:
                        Console.WriteLine("Do something! ");
                        break;
                }
                HpPlayer -= BossDamage;
                Attack = true;
            } while (HpBoss > 0 && HpPlayer > 0); 
            if (HpPlayer <= 0)
            {
                Console.WriteLine("You're dead ");
                Console.ReadKey();
            }
            else if (HpBoss <= 0)
            {
                Console.WriteLine("The boss is defeated ");

                Console.ReadKey();
            }
        }

    }
}
