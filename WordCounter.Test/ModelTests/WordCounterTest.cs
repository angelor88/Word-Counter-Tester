using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class WordFinderTest
  {
    [TestMethod]
    public void GetSentence_ReturnSentence_string()
    {
      //Arrange
      string phrase = "x";
      WordFinder newWordFinder = new WordFinder(phrase);

      //action
      string result = newWordFinder.GetSentence();

      //Assert
      Assert.AreEqual(phrase, result);

    }
  }
}
