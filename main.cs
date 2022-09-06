using System;

class Program {
  public static void Main (string[] args) {
   int userGuess = 0;
    int secretNumber = 0;

  Console.WriteLine("Player 1: Please Enter A Number from 1 - 10");
    secretNumber = int.Parse(Console.ReadLine());


    Console.Clear();

    while (userGuess != secretNumber) {
      Console.WriteLine("Player 2: Please enter your guess");
      userGuess = int.Parse(Console.ReadLine());
      
    }
    Console.WriteLine("WINNER WINNER CHICKEN DINNER!! CONGRATS YOU GUESSED MY NUMBER!");
  }
} 
  