namespace Rock_Paper_Scissors_Technical_Test
{
    public static class Dashboard
    {
        static string? menuSelection;

        //Menu options presented to user
        public static void MainMenuInput()
        {

            Console.WriteLine("Welcome to Rock Paper Scissors");

            Console.WriteLine("Select game mode: \n 1: Against Computer \n 2: Against Human");
            menuSelection = Console.ReadLine();

            MainMenu(menuSelection);

        }

        //Option is selected
        public static void MainMenu(string menuSelection)
        {
            switch (menuSelection)
            {
                case "1":
                    HumanOperations.PlayersTurn(menuSelection);
                    break;

                case "2":
                    HumanOperations.PlayersTurn(menuSelection);
                    break;
                default:
                    Console.WriteLine("Please enter correct input.");
                    MainMenuInput();
                    break;
            }
        }
    }
}
