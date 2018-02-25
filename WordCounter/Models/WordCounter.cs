using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordFinder
  {
    private string _userSentence;
    private string _keyWord;

    public WordFinder(string userSentence, string keyWord)
    {
      _userSentence = userSentence;
      _keyWord = keyWord;
      // _counter = counter;
    }
    public string GetSentence()
    {
      return _userSentence;
    }
    public void SetSentence(string newSentence)
    {
      _userSentence = newSentence;
    }
    public string GetkeyWord()
    {
      return _keyWord;
    }
    public void SetKeyWord(string newKeyWord)
    {
      _keyWord = newKeyWord;
    }

    public int GetCount()
    {
       char[] symbolsToIgnore = { ' ', '?' ,'!', ',', '.', '#', '$'};
       string cleanSentence = _userSentence.ToLower().Trim(symbolsToIgnore);

       if (_keyWord.ToLower().Length == 0 || cleanSentence.Length == 0)
           return 0;

       int counterKeyWords = 0;

       string[] phrases = cleanSentence.Split(' ');
       foreach (string phrase in phrases)
       {
          if(phrase.Equals(_keyWord))
          {
            counterKeyWords ++;
          }
       }
       return counterKeyWords;
    }
  }
}
