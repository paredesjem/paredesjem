using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baccarat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int banker = random.Next(0, 9);
            int player = random.Next(0, 9);

            Console.WriteLine("Banker has " + banker + " and Player has " + player + "\r\n");
            Baccarat(banker,player);
            Console.WriteLine("\r\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        static Boolean Natural(int banker, int player)
        {
            bool win = true;
            if (player == 8 || player == 9)
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins Natural " + banker + " over " + player);
                    
                }
                else if (banker < player)
                {
                    Console.WriteLine("Player wins Natural " + player + " over " + banker);
                }
                else
                {
                    Console.WriteLine("Tie hand");
                }
            }
            else if (banker == 8 || banker == 9)
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins Natural " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    Console.WriteLine("Player wins Natural " + player + " over " + banker);
                }
                else
                {
                    Console.WriteLine("Tie hand");
                }
            }else
            {
                win = false;
            }
            return win;
        }

        static Boolean BankerDrawsZeroTwo(int banker, int player, int playerthird)
        {
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            bool win = true;

            if (banker >= 0 && banker <= 2)
            {
                Console.WriteLine("One card for banker");
                banker += bankerthird;
                if (banker >= 10)
                {
                    banker -= 10;
                }
                Console.WriteLine("Banker now has " + banker);
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }

        static Boolean BankerHasThree(int banker, int player, int playerthird)
        {
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            bool win = true;
            if (banker == 3 && playerthird != 8)
            {

                Console.WriteLine("8 no more! One card for banker");
                banker += bankerthird;
                if (banker >= 10)
                {
                    banker -= 10;
                }
                Console.WriteLine("Banker now has " + banker);
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            else if (banker == 3 && playerthird == 8)
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }


        static Boolean BankerHasFour(int banker, int player, int playerthird)
        {
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            bool win = true;
            if (banker == 4 && (playerthird >= 2 && playerthird <= 7))
            {
                Console.WriteLine("2-7 Draw! One card for banker");
                banker += bankerthird;
                if (banker >= 10)
                {
                    banker -= 10;
                }
                Console.WriteLine("Banker now has " + banker);
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else
                {
                    Console.WriteLine("Tie hand");
                }
            }
            else if(banker == 4 && (playerthird < 2 || playerthird > 7))
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }

        static Boolean BankerHasFive(int banker, int player, int playerthird)
        {
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            bool win = true;
            if (banker == 5 && (playerthird >= 4 && playerthird <= 7))
            {
                Console.WriteLine("4-7 Draw! One card for banker");
                banker += bankerthird;
                if (banker >= 10)
                {
                    banker -= 10;
                }
                Console.WriteLine("Banker now has " + banker);
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else
                {
                    Console.WriteLine("Tie hand");
                }
            }
            else if (banker == 5 && (playerthird < 4 || playerthird > 7))
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }
        static Boolean BankerHasSix(int banker, int player, int playerthird)
        {
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            bool win = true;

            if (banker == 6 && (playerthird >= 6 && playerthird <= 7))
            {
                Console.WriteLine("6-7 Draw! One card for banker");
                banker += bankerthird;
                if (banker >= 10)
                {
                    banker -= 10;
                }
                Console.WriteLine("Banker now has " + banker);
                if (banker > player)
                {
                    win = true;
                    if (banker == 6)
                    {
                        Console.WriteLine("Banker wins Tiger on " + banker + " over " + player);
                    }
                    else if (banker == 7)
                    {
                        Console.WriteLine("Banker wins " + banker + " over " + player);
                    }
                }
                else if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            else if (banker == 6 && (playerthird < 6 || playerthird > 7))
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker wins Tiger on " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }
        static Boolean BankerHasSeven(int banker, int player, int playerthird)
        {
            bool win = true;
            if (banker == 7)
            {
                if (banker > player)
                {
                    win = true;
                    Console.WriteLine("Banker Wins " + banker + " over " + player);
                }
                else if (banker < player)
                {
                    win = false;
                    Console.WriteLine("Player wins " + player + " over " + banker);
                }
                else if (banker == player)
                {
                    Console.WriteLine("Tie hand");
                }
            }
            return win;
        }
        static Boolean PlayerStands(int banker, int player)
        {
            bool stand = true;
            Random random = new Random();
            int bankerthird = random.Next(0, 9);
            if (player >= 6 && player <= 7)
            {
                if (banker >= 0 && banker <= 5)
                {
                    Console.WriteLine("Player stands! One card for banker");
                    banker += bankerthird;
                    if (banker >= 10)
                    {
                        banker -= 10;
                    }
                    Console.WriteLine("Banker now has " + banker);

                    if (banker > player)
                    {
                        Console.WriteLine("Banker wins " + banker + " over " + player);
                    }
                    else if (banker < player)
                    {
                        Console.WriteLine("Player wins " + player + " over " + banker);
                    }
                    else if (banker == player)
                    {
                        Console.WriteLine("Tie hand");
                    }
                }
                else if (banker >= 6 && banker <= 7)
                {
                    if (banker > player)
                    {
                        Console.WriteLine("Banker wins " + banker + " over " + player);
                    }
                    else if (banker < player)
                    {
                        Console.WriteLine("Player wins " + player + " over " + banker);
                    }
                    else if (banker == player)
                    {
                        Console.WriteLine("Tie hand");
                    }
                }
            }
            return stand;
        }
        static void PlayerDraws(int banker, int player)
        {
            if (player >= 0 && player <= 5) 
            {
                Random random = new Random();
                int playerthird = random.Next(0, 9);
                Console.WriteLine("One card for player");
                player += playerthird;
                if (player >= 10)
                {
                    player -= 10;
                }
                Console.WriteLine("Player now has " + player);
                BankerDrawsZeroTwo(banker, player, playerthird);
                BankerHasThree(banker, player, playerthird);
                BankerHasFour(banker, player, playerthird);
                BankerHasFive(banker, player, playerthird);
                BankerHasSix(banker, player, playerthird);
                BankerHasSeven(banker, player, playerthird);
            }
        }
        static void Baccarat(int banker, int player)
        {
            if (Natural(banker, player) == false)
            {
                PlayerDraws(banker, player);
                PlayerStands(banker, player);
            }            
        }
    }
}