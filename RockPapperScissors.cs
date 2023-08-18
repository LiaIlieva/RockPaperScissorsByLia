namespace RockPapperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string Rock = "Rock";
            const string Papper = "Papper";
            const string Scissors = "Scissors";
            Console.Write("Choose: [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "papper")
            {
                playerMove = Papper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = "Rock";
                    break;
                case 2:
                    computerMove = "Papper";
                    break;
                case 3:
                    computerMove = "Scissors";
                    break;

            }
            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == "Rock" && computerMove == "Scissors")
                || (playerMove == "Papper" && computerMove == "Rock")
                || (playerMove == "Scossors" && computerMove == "Papper"))
            {
                Console.WriteLine("You win!");
            }
            else if ((computerMove == "Rock" && playerMove == "Scissors")
                || (computerMove == "Papper" && playerMove == "Rock")
                || (computerMove == "Scossors" && playerMove == "Papper"))
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}