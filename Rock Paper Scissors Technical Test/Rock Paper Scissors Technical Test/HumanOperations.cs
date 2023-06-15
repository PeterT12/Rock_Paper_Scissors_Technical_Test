namespace Rock_Paper_Scissors_Technical_Test
{
    public static class HumanOperations
    {
        static  Person playerOne = new Person();
        static Person playerTwo = new Person();
        static bool result;

        //Users enter and validated their choices
        public static void PlayersTurn(string input)
        {
            Console.Clear();

            Computing computing = new Computing();

            for (int i = 3; i >= Computing.playerOneScore || i >= Computing.playerTwoScore;)
            {
                do
                {
                    Console.WriteLine("\nPlayer Ones Turn...");
                    playerOne.Turn();
                } while (ValidateInput(input, playerOne.getInput()) == false);


                    if (input == "1")
                    {
                        ComputerOperations.ComputersTurn(playerOne.getInput());
                        
                    }
                    else if (input == "2")
                    {
                    do
                    {
                        Console.WriteLine("\nPlayer Twos Turn...");
                        playerTwo.Turn();
                    } while (ValidateInput(input, playerTwo.getInput()) == false);

                       computing.computeRound(playerOne.getInput(), playerTwo.getInput());
                    }         
                               
            }
        }

            //Users input is validated
            public static bool ValidateInput(string input, string userInput)
            {      
                if (userInput == "1" || userInput == "2" || userInput == "3")
                {
                return result = true;    
                }
                else
                {
                Console.WriteLine("Input a valid number");
                return result = false;                
                }
            }

    }
}
