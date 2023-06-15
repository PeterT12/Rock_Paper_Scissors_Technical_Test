using RockPaperScissorsTechnicalTest;

namespace Rock_Paper_Scissors_Technical_Test
{
    class Computing
    {
       static List<string> turnList = new List<string>();
       static private int turns = 0;
       static  internal int playerOneScore = 0;
       static internal int playerTwoScore = 0;

        //Round win is calculated
         public void computeRound(string PlayerOneInput, string PlayerTwoInput)
        {
            turns++;
      
            if (PlayerOneInput == "1" && PlayerTwoInput == "1" || PlayerOneInput == "2" && PlayerTwoInput == "2" || PlayerOneInput == "3" && PlayerTwoInput == "3") //Draw scenarios
            {

            }
            else if (PlayerOneInput == "1" && PlayerTwoInput == "3" || PlayerOneInput == "2" && PlayerTwoInput == "1" || PlayerOneInput == "3" && PlayerTwoInput == "2") // User victory scenarios
            {
                playerOneScore++;
            }
            else // Computer victory scenarios
            {
                playerTwoScore++;
            }

            ComputeTotal(playerOneScore, playerTwoScore, turns, PlayerOneInput, PlayerTwoInput);

        }

        //Total score and winner is shown. Various specs suc as total turns and most common move are displayed. 
        public void ComputeTotal(int playerOneScore, int playerTwoScore, int turns, string UserInput, string ComputerInput)
        {

            
            turnList.Add(UserInput);
            turnList.Add(ComputerInput);

            string most = turnList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
            .Select(grp => grp.Key).First();


            if (playerOneScore == 3)
            {
                Console.WriteLine("Player One Wins!");
                Console.WriteLine($"This game took: {turns} turns");
                Console.WriteLine($"The most used turn was {most}");
               
                replayOption();
            }
            else if (playerTwoScore == 3)
            {
                Console.WriteLine("Player Two Wins");
                Console.WriteLine($"This game took: {turns} turns");
                Console.WriteLine($"The most used turn was {most}");
              
                replayOption();               
            }

        }

        //After game is finished the user is presented with options to play again or exit
        public void replayOption()
        {
            Console.WriteLine("Play again? \n Press '1' for YES \n Press '2' for NO");
            string replayChoice = Console.ReadLine();

            ResetOrExitApplication(replayChoice);
        }

        //Users replay or exit choice is carried out
        public void ResetOrExitApplication(string replayChoice)
        {
            switch (replayChoice) 
            {
                case "1":
                    playerOneScore = 0;
                    playerTwoScore = 0;
                    turns = 0;
                    turnList.Clear();
                    Dashboard.MainMenuInput();
                    break;
                case "2":
                     Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter correct input.");
                    replayOption();
                    break;

            }
        }
    }

}
