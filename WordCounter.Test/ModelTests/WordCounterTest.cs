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
      string phrase = "Hello Epicodus!";
      WordFinder newWordFinder = new WordFinder(phrase, "");

      //action
      string result = newWordFinder.GetSentence();

      //Assert
      Assert.AreEqual(phrase, result);

    }
    [TestMethod]
    public void CountKeyWord_ReturnKeyWordsInSentence()
    {
      //Arrange
      string mySentence = "Hello from Seattle! Hello World!";
      string myKeyWord = "hello";
      WordFinder testTwo = new WordFinder(mySentence, myKeyWord);

      //Action
      int resultTwo = testTwo.GetCount();

      //Assert
      Assert.AreEqual(3, resultTwo);

    }
    // [TestMethod]
    // public void CheckIfTheSentenceIsaNumber()
    // {
      //Arrange

      //Action

      //Assert
    // }
  }
}
