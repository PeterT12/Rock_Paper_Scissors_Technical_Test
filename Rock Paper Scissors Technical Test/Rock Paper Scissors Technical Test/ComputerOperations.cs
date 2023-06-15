namespace Rock_Paper_Scissors_Technical_Test
{
    public static class ComputerOperations
    {
        //Computer makes its choice
        static public void ComputersTurn(string playerOneInput)
        {  string? playerTwoInput;
            Dictionary<int, string> computersSelection = new Dictionary<int, string>();
            computersSelection.Add(1, "Rock");
            computersSelection.Add(2, "Paper");
            computersSelection.Add(3, "Scissors");

            Random randomSelection = new Random();

            int selection = randomSelection.Next(1, 3);

            Console.WriteLine("The computer has chosen: " + computersSelection[selection]);

            playerTwoInput = selection.ToString();

            Computing computing = new Computing();  
            computing.computeRound(playerOneInput, playerTwoInput);
        }

    }
}
