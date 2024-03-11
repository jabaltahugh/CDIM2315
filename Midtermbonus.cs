using System;

class HumanPlayer
{
    private int points; // the points that the human player has
    
    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Enter your decision (Rock, Paper, or Scissors): ");
        string decision = Console.ReadLine().ToLower();
        while (decision != "rock" && decision != "paper" && decision != "scissors")
        {
            Console.WriteLine("Invalid input! Please enter Rock, Paper, or Scissors: ");
            decision = Console.ReadLine().ToLower();
        }
        return decision;
    }
}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random random = new Random();
        string[] choices = { "rock", "paper", "scissors" };
        return choices[random.Next(choices.Length)];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer humanPlayer = new HumanPlayer(5);
        ComputerPlayer computerPlayer = new ComputerPlayer();
        
        while (humanPlayer.GetPoints() > 0)
        {
            Console.WriteLine("Your points: " + humanPlayer.GetPoints());

            string humanDecision = humanPlayer.HumanDecision();
            string computerDecision = computerPlayer.ComputerDecision();

            Console.WriteLine("Computer chooses: " + computerDecision);

            if (humanDecision == computerDecision)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((humanDecision == "rock" && computerDecision == "scissors") ||
                     (humanDecision == "paper" && computerDecision == "rock") ||
                     (humanDecision == "scissors" && computerDecision == "paper"))
            {
                Console.WriteLine("You win!");
                humanPlayer.WinRound();
            }
            else
            {
                Console.WriteLine("You lose!");
                humanPlayer.LoseRound();
            }

            Console.WriteLine("Do you want to play another round? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "yes")
                break;
        }

        Console.WriteLine("Game Over!");
    }
}
