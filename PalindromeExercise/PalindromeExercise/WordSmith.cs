﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var wordReverse = "";
          for (int i = word.Length - 1; i >= 0; i--)
            {
                wordReverse += word[i];
            }
          if (wordReverse.ToLower() == word.ToLower() && word != "")
            {
                return true;
            }
          else
            {
                return false;
            }
        }
     }
}
