using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns1ForCharacters()
    {
      List<string> letters = new List<string> {
        "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" 
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 1);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns2ForCharacters()
    {
      List<string> letters = new List<string> {
        "D", "G", 
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 2);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns3ForCharacters()
    {
      List<string> letters = new List<string> {
        "B", "C",  "M", "P"
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 3);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns4ForCharacters()
    {
      List<string> letters = new List<string> {
        "F", "H",  "V", "W", "Y"
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 4);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns5ForCharacters()
    {
      List<string> letters = new List<string> {
        "K"
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 5);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns8ForCharacters()
    {
      List<string> letters = new List<string> {
        "J", "X"
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 8);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForSingleCharacters_Returns10ForCharacters()
    {
      List<string> letters = new List<string> {
        "Q", "Z"
      };

      foreach (string letter in letters) 
      {
        Assert.AreEqual(Program.Solve(letter), 10);
      }
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForTwoCharacters_Returns2 ()
    {
      Assert.AreEqual(Program.Solve("IT"), 2);
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForTwoCharacters_Returns5 ()
    {
      Assert.AreEqual(Program.Solve("EW"), 5);
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForThreeCharacters_Returns5 ()
    {
      Assert.AreEqual(Program.Solve("ADD"), 5);
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForTenCharacters_Returns18 ()
    {
      Assert.AreEqual(Program.Solve("STRAWBERRY"), 18);
    }

    [TestMethod]
    public void Solve_GivesCorrectScoreForAnyCasing_Returns5 ()
    {
      Assert.AreEqual(Program.Solve("adD"), 5);
    }
  }
}