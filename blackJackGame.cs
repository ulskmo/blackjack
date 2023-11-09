
internal class blackJackGame
{
    public void DealingMethodForPlayer(List<string> suits, List<int> ranks, ref int number1, ref int number2)
    {
        Random randomRanks = new Random();
        Random randomRanks2 = new Random();
        Random randomSuits = new Random();

        int randomRanksIndex = randomRanks.Next(ranks.Count);
        int randomRanksIndex2 = randomRanks2.Next(ranks.Count);
        string randomSuitsIndex = suits[randomSuits.Next(suits.Count)];
        string randomSuitsIndex2 = suits[randomSuits.Next(suits.Count)];

        number1 = ranks[randomRanksIndex];
        number2 = ranks[randomRanksIndex2];

        //hack - remove
        number1 = 1;
        number2 = 1;

        int result = number1 + number2;


       

        Console.WriteLine("Card dealt is the " + number1 + " of " + randomSuitsIndex + ", value " + number1);
        Console.WriteLine("Card dealt is the " + number2 + " of " + randomSuitsIndex2 + ", value " + number2);
        Console.WriteLine($"Your score is {result}");

    }// END OF DEALING METHOD FOR PLAYER

    public void DealingMethodForDealer(List<string> suits, List<int> ranks, ref int dealerresult)
    {
        Random randomRanks = new Random();
        Random randomRanks2 = new Random();
        Random randomSuits = new Random();

        int randomRanksIndex = randomRanks.Next(ranks.Count);
        int randomRanksIndex2 = randomRanks2.Next(ranks.Count);
        string randomSuitsIndex = suits[randomSuits.Next(suits.Count)];
        string randomSuitsIndex2 = suits[randomSuits.Next(suits.Count)];

        int selectedNumber = ranks[randomRanksIndex];
        int selectedNumber2 = ranks[randomRanksIndex2];

        dealerresult += selectedNumber + selectedNumber2; // Mevcut değere eklemek

        Console.WriteLine("Card dealt is the " + selectedNumber + " of " + randomSuitsIndex + ", value " + selectedNumber);
        Console.WriteLine("Card dealt is the " + selectedNumber2 + " of " + randomSuitsIndex2 + ", value " + selectedNumber2);
        Console.WriteLine($"Dealer score is {dealerresult}");
        Console.WriteLine("");

        if (dealerresult <= 16)
        {
            Console.WriteLine("Dealer taking one more card");

            Random randomRanks3 = new Random();
            int randomRanksIndex3 = randomRanks3.Next(ranks.Count);
            Random randomSuits3 = new Random();
            string randomSuitsIndex3 = suits[randomSuits3.Next(suits.Count)];

            int selectedNumber3 = ranks[randomRanksIndex3];
            dealerresult += selectedNumber3; // Mevcut değere eklemek

            Console.WriteLine("Card dealt is the " + selectedNumber3 + " of " + randomSuitsIndex3 + ", value " + selectedNumber3);
            Console.WriteLine($"Dealer NEW score is {dealerresult}");
            Console.WriteLine("");

            if (dealerresult <= 16)
            {
                Console.WriteLine("Dealer taking one more card");

                Random randomRanks4 = new Random();
                int randomRanksIndex4 = randomRanks4.Next(ranks.Count);
                Random randomSuits4 = new Random();
                string randomSuitsIndex4 = suits[randomSuits4.Next(suits.Count)];

                int selectedNumber4 = ranks[randomRanksIndex3];
                dealerresult += selectedNumber4;

                Console.WriteLine("Card dealt is the " + selectedNumber4 + " of " + randomSuitsIndex4 + ", value " + selectedNumber4);
                Console.WriteLine($"Dealer NEW score is {dealerresult}");
                Console.WriteLine("");
            }
        }

    }// END OF METHOD

}
