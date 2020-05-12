using System;
using System.Collections.Generic;
using Anagramatron.Models;

namespace Program
{
  class AnagramFront
  {
    public static void Main()
    {
      bool run = true;
      while(run == true)
      {
      Anagram grams = new Anagram();
      Console.WriteLine("Welcome to the Anagramatron.\n\nPlease enter a word to anagram:");
      string input = Console.ReadLine();
      Anagram.GetInput(input);
      Enter:
      Console.WriteLine("Now enter a possible anagram of that word:");
      string gram = Console.ReadLine();
      Anagram.AddCheckList(gram);
      Console.WriteLine("Would you like to add another word to check? [Y / N]");
      string addNew = (Console.ReadLine().ToLower());
      if (addNew == "y")
      {
        goto Enter;
      }
      else
      {
        Anagram.CheckGrams();
      }
      }
    }
  }
}