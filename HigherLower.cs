using System;
using System.Collections.Generic;

namespace HigherLower {

  public class Program
  {
    public static void Main()
    {
      double guessNumber = 50;
      double maxGuess = 100;
      double minGuess = 1;
      Console.WriteLine("Is your Number " + guessNumber +"?");
      string userAnswer = Console.ReadLine();
      while((userAnswer == "higher") || (userAnswer == "lower")){
        double incrementGuess = Math.Round((maxGuess-guessNumber)/2);
        if(userAnswer == "higher"){
          minGuess = guessNumber;
          guessNumber += incrementGuess;
          Console.WriteLine("Is your number " + guessNumber + " or higher or lower?");
        } else {
          maxGuess = guessNumber;
          guessNumber -= incrementGuess;
          Console.WriteLine("Is your number " + guessNumber + " or higher or lower?");
        }
        userAnswer = Console.ReadLine();
      }
      Console.WriteLine("I guessed your number!");
      }
    }
  }
