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
      char [] stringToCharacters = _originalString.ToCharArray();
      // int _originalStringLength = stringToCharacters.Length;
      //
      char [] charWordToBeReplaced = _wordToBeReplaced.ToCharArray();
      // int lengthOfWord = _charWordToBeReplaced.Length;

      for (int i = 0; i < _originalString.Length; i++)
      {
        if (stringToCharacters[i] == charWordToBeReplaced[0])
        {
          char [] wordpointer;

          for (int j = i; j < i + _wordToBeReplaced.Length; j++)
          {
            wordpointer.Add(stringToCharacters[j]);
          }

          if (wordpointer == charWordToBeReplaced)
          {
            int m = 0;
            for (int k = i; k < i + _wordToBeReplaced.Length; k++)
            {
              stringToCharacters.RemoveAt(k);
            }

            for (int l = i; l < i + _replacementWord; l++)
            {
              Array.insert(stringToCharacters, l, m);
              m++;
            }
          }
        }
      }

      foreach (char character in stringToCharacters)
      {
        _editedString += character;
      }

      return _editedString;
    }

    //   foreach (string character in stringToCharacters)
    //   {
    //     if (word == _wordToBeReplaced)
    //     {
    //       _editedStringList.Add(_replacementWord);
    //       _editedStringList.Add(" ");
    //     }
    //     else
    //     {
    //       _editedStringList.Add(word);
    //       _editedStringList.Add(" ");
    //     }
    //   }
    //
    //   _editedStringList.RemoveAt(_editedStringList.Count - 1);
    //
    //   foreach (string filteredWord in _editedStringList)
    //   {
    //     _editedString += filteredWord;
    //   }
    //
    //   return _editedString;
    // }

  }
}
