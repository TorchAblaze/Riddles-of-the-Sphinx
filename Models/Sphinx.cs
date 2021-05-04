using System;
using Riddles.Models;

namespace Riddles.Models {
  public class Sphinx
  {
    public string Riddle{ get; set; }
    public string Answer{ get; set; }

    public Sphinx(string riddle, string answer)
    {
      Riddle = riddle;
      Answer = answer;
    }

    public bool RightAnswer(string userAnswer)
    {
      userAnswer = userAnswer.ToLower();
      if (Answer.Contains(userAnswer))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}