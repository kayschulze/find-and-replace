using System.Collections.Generic;
using System;

namespace FindAndReplace.Models
{
  public class FindReplace
  {
    string _originalString = "";
    string _replacementWord = "";
    string _wordToBeReplaced = "";
    string _editedString = "";
    List<string> _editedStringList = new List<string> {};
    string [] _parsedWords;


    public FindReplace(string originalString, string wordToBeReplaced, string replacementWord)
    {
      _originalString = originalString;
      _wordToBeReplaced = wordToBeReplaced;
      _replacementWord = replacementWord;
    }

    public string FindAndReplace()
    {
      char [] extrachars = {' ', '.'};

      _parsedWords = _originalString.Split(extrachars);
      Console.WriteLine(_parsedWords);

      foreach (string word in _parsedWords)
      {
        if (word == _wordToBeReplaced)
        {
          _editedStringList.Add(_replacementWord);
        }
        else
        {
          Console.WriteLine("Howdy!");
          _editedStringList.Add(word);
        }
      }

      foreach (string filteredWord in _editedStringList)
      {
        _editedString += filteredWord;
        _editedString += " ";
      }

      return _editedString;
    }

  }
}
