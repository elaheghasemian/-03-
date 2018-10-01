using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teniss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first player's name:");
            string player1 = Console.ReadLine();
            Console.Beep(1000, 200);
            Console.WriteLine("Please enter the second  player's name:");
            string player2 = Console.ReadLine();
            Console.Beep(1000, 200);
            Console.WriteLine("player1:" + player1);
            Console.WriteLine("player2:" + player2);
            Console.WriteLine("---------------");
            Game(player1, player2);
        }
        public static void Game(string Player1, string Player2)
        {
            int Player1Point = 0;
            int Player2Point = 0;
            int Player1Set = 0;
            int Player2Set = 0;
            int Player1Game = 0;
            int Player2Game = 0;
            bool Player1AD = false;
            bool Player2AD = false;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{Player1.Substring(0, 3)} point is:{Player1Point} set is:{Player1Set} game is:{Player1Game} AD:{Player1AD}");
                Console.WriteLine($"{Player2.Substring(0, 3)} point is:{Player2Point} set is:{Player2Set} game is:{Player2Game} AD:{Player2AD}");
                Console.WriteLine("Add points");
                string point = Console.ReadLine();
                switch (Convert.ToInt64(point))
                {
                    case 1:
                        if (Player1Point != 40)
                        {
                            if (Player1Point < 30)
                            {
                                Player1Point += 15;
                            }
                            else
                            {
                                Player1Point += 10;
                            }
                            if (Player2Point == 40 && Player1Point == 40)
                            {
                                if (Player1AD != true)
                                {
                                    Player1AD = true;
                                }
                            }
                        }
                        else if (Player1Point == 40)
                        {
                            if (Player1AD == true)
                            {
                                Player1Point = 0;
                                Player1Set += 1;
                                Player1AD = false;
                                Player2Point = 0;
                            }
                            else
                            {
                                Player1Point = 0;
                                Player1Set += 1;
                                Player2Point = 0;
                                Player2AD = false;
                            }
                        }
                        if (Player2Set + 2 == Player1Set || Player1Set == 7)
                        {
                            Player1Game += 1;
                            Player1Set = 0;
                            Player2Set = 0;
                        }
                        Console.Beep(1000, 200);
                        break;
                    case 2:
                        if (Player2Point != 40)
                        {
                            if (Player2Point < 30)
                            {
                                Player2Point += 15;
                            }
                            else
                            {
                                Player2Point += 10;
                            }
                            if (Player1Point == 40 && Player2Point == 40)
                            {
                                if (Player2AD != true)
                                {
                                    Player2AD = true;
                                }
                            }
                        }
                        else if (Player2Point == 40)
                        {
                            if (Player2AD == true)
                            {
                                Player2Point = 0;
                                Player2Set += 1;
                                Player2AD = false;
                                Player1Point = 0;
                            }
                            else
                            {
                                Player2Point = 0;
                                Player2Set += 1;
                                Player1Point = 0;
                                Player1AD = false;
                            }
                        }
                        if (Player1Set + 2 == Player2Set || Player2Set == 7)
                        {
                            Player2Game += 1;
                            Player2Set = 0;
                            Player1Set = 0;
                        }
                        Console.Beep(1000, 200);
                        break;
                    default:
                        Console.WriteLine(" point is not valid");
                        break;
                }

            }
        }
    }
}
