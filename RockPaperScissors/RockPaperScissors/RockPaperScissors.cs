// See https://aka.ms/new-console-template for more information
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
string playMove = Console.ReadLine();
if (playMove=="r" || playMove=="rock")
{
    playMove = Rock;
}
else if (playMove=="p" || playMove=="paper")
{
    playMove = Paper;
}
else if (playMove == "s" || playMove == "scissors")
{
    playMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";
switch (computerRandomNumber)
{
    case 1:computerMove = Rock;
        break;
    case 2:computerMove = Paper;
        break;
    case 3:computerMove = Scissors;
        break;
  
}
Console.WriteLine($"The computer choose {computerMove}.");

if ((playMove == Rock && computerMove == Scissors) || (playMove ==Paper  && computerMove == Rock) 
    ||(playMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You win.");
}
else if ((playMove == Rock && computerMove == Paper) || (playMove == Paper && computerMove == Scissors)
    || (playMove == Scissors && computerMove == Rock))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}


