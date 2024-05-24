using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsPalindrome(string word) 
        {
            var wordToCharArr = word.ToCharArray();
            Array.Reverse(wordToCharArr);
            return word.SequenceEqual(wordToCharArr);
        }
    }
}
