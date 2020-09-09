using System;
using System.Threading.Channels;

namespace RockpaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Please choose either rock, paper or scissors: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToLower();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    if (inputPlayer != "rock" && inputPlayer != "paper" && inputPlayer != "scissors")

                    {
                        Console.Write("Invalid input - ");
                        continue;
                    }

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("Computer chose Rock");

                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Draw\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("Computer Wins!\n");
                                scoreCPU++;
                            }

                            break;

                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose Paper");
                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Draw\n");
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Computer wins\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("Player Wins!\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer chose Scissors");
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("Draw\n");
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Player wins\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Computer Wins!\n");
                                scoreCPU++;
                            }
                            break;
                        default:

                            break;
                    }

                    Console.WriteLine("\n\n Scores:\tPlayer:\t{0}\tComputer:\t{1}",scorePlayer, scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player wins!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer wins!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    
                }
            }

            

        }
    }
}
