using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsAPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
            //throw new NotImplementedException();
        }

    }
}
