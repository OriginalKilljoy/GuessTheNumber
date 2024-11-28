//Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
//Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere, helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt

Random randomNumber = new Random();
var correctNumber = randomNumber.Next(1,101);


Console.WriteLine("Hello! Guess a number between 1-100");
GuessingGame();

void GuessingGame()
{
    var userGuess = Console.ReadLine();
    int guess = int.Parse(userGuess);
    NumberChecker(guess);
}



void NumberChecker(int guess)
{
    if (guess < correctNumber)
    {
        Console.WriteLine("Higher;)");
        GuessingGame();
    }
    else if (guess > correctNumber)
    {
        Console.WriteLine("Lower;)");
        GuessingGame();
    }
    else
    {
        Console.WriteLine("Correct!!");
    }
}
