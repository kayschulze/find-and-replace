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

    public FindReplace(string originalString, string wordToBeReplaced, string replacementWord)
    {
      _originalString = originalString;
      _wordToBeReplaced = wordToBeReplaced;
      _replacementWord = replacementWord;
    }

    public string FindAndReplace()
    {
      int originalStringLength = _originalString.Length;
      int wordToBeReplacedLength = _wordToBeReplaced.Length;
      int replacementWordLength = _replacementWord.Length;

      char [] stringToCharacters = _originalString.ToCharArray();
      List<char> stringToCharactersList = new List<char> {};

      for (int h = 0; h < originalStringLength; h++)
      {
        stringToCharactersList.Add(stringToCharacters[h]);
      }

      char [] replacementArray = _replacementWord.ToCharArray();
      List<char> replacementList = new List<char> {};

      for (int g = 0; g < replacementWordLength; g++)
      {
        replacementList.Add(replacementArray[g]);
      }

      char [] charWordToBeReplaced = _wordToBeReplaced.ToCharArray();

      for (int i = 0; i < originalStringLength; i++)
      {
        if (stringToCharactersList[i] == charWordToBeReplaced[0])
        {
          string wordpointer = "";

          for (int j = i; j < i + wordToBeReplacedLength; j++)
          {
            wordpointer += stringToCharactersList[j];
          }

          if (wordpointer == _wordToBeReplaced)
          {
            int m = replacementWordLength - 1;
            int eraseindex = i + wordToBeReplacedLength;
            int replaceindex = i + replacementWordLength;

            for (int k = i; k < eraseindex; k++)
            {
              stringToCharactersList.RemoveAt(i);
            }

            for (int l = i; l < replaceindex; l++)
            {
              stringToCharactersList.Insert(i, replacementList[m]);
              m--;
            }
            i += replacementWordLength;
          }
        }
      }

      foreach (char character in stringToCharactersList)
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
