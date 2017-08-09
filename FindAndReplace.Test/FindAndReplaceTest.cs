using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;
using System.Collections.Generic;
using System;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {
    [TestMethod]
    public void FindAndReplace_ReplaceOneWordWithAnother_Universe()
    {
      string originalString = "world";
      string wordToBeReplaced = "world";
      string replacementWord = "universe";
      FindReplace className = new FindReplace(originalString, wordToBeReplaced, replacementWord);
      string expected = "universe ";

      string actual = className.FindAndReplace();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FindAndReplace_ReplaceOneWordInAStringOfWords_Universe()
    {
      //Arrange
      string expected = "hello universe ";
      string originalString = "hello world";
      string wordToBeReplaced = "world";
      string replacementWord = "universe";

      //Act
      FindReplace className = new FindReplace(originalString, wordToBeReplaced, replacementWord);
      string actual = className.FindAndReplace();


      //Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
