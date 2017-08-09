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

      foreach (string word in _parsedWords)
      {
        if (word == _wordToBeReplaced)
        {
          _editedStringList.Add(_replacementWord);
          _editedStringList.Add(" ");
        }
        else
        {
          _editedStringList.Add(word);
          _editedStringList.Add(" ");
        }
      }

      _editedStringList.RemoveAt(_editedStringList.Count - 1);

      foreach (string filteredWord in _editedStringList)
      {
        _editedString += filteredWord;
      }

      return _editedString;
    }

  }
}
