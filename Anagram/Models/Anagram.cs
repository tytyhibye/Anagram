using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagramatron.Models
{
  public class Anagram
  {
    public static string Input {get; set;}
    public static List<string> checks = new List<string>{};
    public static List<string> anagrams = new List<string>{};

    public static void GetInput(string input)
    {
      Input = input.ToLower();
    }

    public static void AddCheckList(string input)
    {
      checks.Add(input.ToLower());
    }

    public static bool CheckGrams()
    { 
      bool isGram = true;
      foreach (string word in checks)
      {
        // Console.WriteLine("first forEach loop");
        if (word.Length != Input.Length)
        {
          isGram = false;
        }
        else if (word.Length == Input.Length)
        {
          char[] inputArray = Input.ToCharArray();
          Array.Sort(inputArray);
          string newInput = string.Join("", inputArray);
          char[] checkArray = word.ToCharArray();
          Array.Sort(checkArray);
          string result = string.Join("", checkArray);
          if (newInput != result)
            {
              isGram = false;
            }
            else
            {
              isGram = true;
              anagrams.Add(word);
            }
        }
        else
        {
          isGram =  false;
        }
      }
      foreach (string finalGram in anagrams)
      {
      Console.WriteLine(finalGram + " is an anagram of " + Input + "!");
      }
      Console.WriteLine(anagrams.Count);
      return isGram;
     
    }
  }
}