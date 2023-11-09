namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<int> ranks = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.Write("Place your bet: ");
            int money = int.Parse(Console.ReadLine());

            string answer = "";
            string anothercard = "";

            int num1 = 0;
            int num2 = 0;

            int newresult = 0;
            int dealerresult = 0;
            int newresult2 = 0;

            int bet = money * 2;

            blackJackGame game = new blackJackGame(); // blackJackGame class create

            do
            {
                game.DealingMethodForPlayer(suits, ranks, ref num1, ref num2);//
                Console.WriteLine("");
                Console.Write("Do you want to stick or twist - [s/t]? : ");
                answer = Console.ReadLine();

                if (answer == "t")
                {
                    Console.WriteLine("");
                    Random randomRanks3 = new Random();
                    int randomRanksIndex3 = randomRanks3.Next(ranks.Count);
                    int selectedNumber3 = ranks[randomRanksIndex3];
                    Random randomSuits = new Random();
                    string randomSuitsIndex3 = suits[randomSuits.Next(suits.Count)];

                    Console.WriteLine("NEW Card dealt is the " + selectedNumber3 + " of " + randomSuitsIndex3 + ", value " + selectedNumber3);
                    newresult = num1 + num2 + selectedNumber3;
                    Console.WriteLine($"New result is {newresult}");

                    Console.WriteLine("Do you want another card? (y/n)");
                    anothercard = Console.ReadLine();

                    if (anothercard == "y")
                    {
                        Random randomRanks4 = new Random();
                        int randomRanksIndex4 = randomRanks4.Next(ranks.Count);
                        int selectedNumber4 = ranks[randomRanksIndex4];
                        Random randomSuits2 = new Random();
                        string randomSuitsIndex4 = suits[randomSuits2.Next(suits.Count)];

                        Console.WriteLine("NEW Card dealt is the " + selectedNumber4 + " of " + randomSuitsIndex4 + ", value " + selectedNumber4);
                        newresult = num1 + num2 + selectedNumber3 + randomRanksIndex4 + 1;
                        Console.WriteLine($"New result is {newresult}");
                    }




                    //DEALER PLAYES
                    Console.WriteLine("");
                    Console.WriteLine("Dealer plays");
                    game.DealingMethodForDealer(suits, ranks, ref dealerresult);// class
                    Console.WriteLine("");

                    if (newresult > 21)
                    {
                        Console.WriteLine("Dealer Wins");
                    }
                    else if (dealerresult > 21 && newresult < 22)
                    {
                        Console.WriteLine($"Player Wins and won {bet:c}");
                    }
                    else if (dealerresult > newresult)
                    {
                        Console.WriteLine("Dealer Wins");
                    }
                    else if (dealerresult < newresult)
                    {
                        Console.WriteLine("Player Wins");
                    }
                    else if (newresult == dealerresult)
                    {
                        Console.WriteLine($"Draw and return money {money}");
                    }
                    
                    
                    else
                    {
                        Console.WriteLine($"Player Wins and won {bet:c}");
                    }


                    //not sure if needed
                    //if (newresult == null)
                    //{
                    //    if (newresult2 > 21)
                    //    {
                    //        Console.WriteLine("Dealer Wins");
                    //    }
                    //    else if (dealerresult > 21)
                    //    {
                    //        Console.WriteLine("PLAYER WINS");
                    //    }
                    //    else if (dealerresult > newresult2)
                    //    {
                    //        Console.WriteLine("Dealer Wins");
                    //    }

                    //    else if (newresult2 == dealerresult)
                    //    {
                    //        Console.WriteLine($"Draw and return money {money}");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine($"Player Wins and won {bet}");
                    //    }
                    //}

                    break;
                }

                else if (answer == "s")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dealer plays");
                    newresult = num1 + num2;
                    game.DealingMethodForDealer(suits, ranks, ref dealerresult);//
                    Console.WriteLine("");

                    if (newresult > 21)
                    {
                        Console.WriteLine("Dealer Wins");
                    }
                    else if (newresult > dealerresult)
                    {
                        Console.WriteLine($"Player Wins and won {bet}");
                    }
                    else if (newresult == dealerresult)
                    {
                        Console.WriteLine($"Draw and return money {money}");
                    }
                    else if (dealerresult > 21)
                    {
                        Console.WriteLine($"Player Wins and won {bet}");
                    }
                    else
                    {
                        Console.WriteLine("Dealer wins");
                    }
                }

                else
                {
                    Console.WriteLine("You entered the wrong value");
                }

            } while (answer != "s");

            Console.ReadLine();
        }
    }
}