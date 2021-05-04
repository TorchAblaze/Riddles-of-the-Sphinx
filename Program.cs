using System;
using System.Collections.Generic;
using Riddles.Models;

namespace Riddles {
  public class Program
  {
    public static void Main()
    {
      Sphinx firstRiddle = new Sphinx("What 4-letter word can be written forward, backward or upside down, and can still be read from left to right?", "noon");
      Sphinx secondRiddle = new Sphinx("What kind of goose fights with snakes?", "mongoose");
      Sphinx thirdRiddle = new Sphinx("You answer me, although I never ask you questions. What am I?", "a telephone");
      Sphinx fourthRiddle = new Sphinx("I am wet when drying. What am I?", "a towel");
      Sphinx fifthRiddle = new Sphinx("What word is always pronounced wrong?", "wrong");

      List<Sphinx> Sphinx = new List<Sphinx>() { firstRiddle, secondRiddle, thirdRiddle, fourthRiddle, fifthRiddle };
      
      foreach (Sphinx riddle in Sphinx)
      {
        Console.WriteLine(riddle.Riddle);
        string userAnswer = Console.ReadLine();
        if (riddle.RightAnswer(userAnswer))
        {
          Console.WriteLine("That was correct!");
          if (riddle == Sphinx[Sphinx.Count-1])
          {
            Console.WriteLine("You guessed correctly! You answered all the riddles correctly! Congrats, I will not eat an intelligent person like yourself :3");
          }
          else
          {
            Console.WriteLine("You guessed correctly! Next riddle...");
          }
        }
        else
        {
          Console.WriteLine("That was incorrect! I'm going to eat you now >:3 NOM NOM NOM");
          break;
        }
      }
    }
  }
}
