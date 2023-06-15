namespace Rock_Paper_Scissors_Technical_Test
{
    internal class Person
    {
        string? input;
    
        //User enters their choice
        public string Turn()
        {
            Console.WriteLine($"\nPlayer One Score: {Computing.playerOneScore} \t Player Two Score: {Computing.playerTwoScore}");
            Console.WriteLine("\n 1:Rock \n 2:Paper \n 3:Scissors");
         
            return input = Console.ReadLine();          
        }

        //Player choice can be recieved
        public string getInput()
        {
            return input;
        }
    }
}
