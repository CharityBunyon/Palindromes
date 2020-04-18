using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public bool Check(string palindrome, string rev)
        { 
            palindrome = Regex.Replace(palindrome, "[^a-zA-Z]", "").ToLower();
            char[] ch = palindrome.ToCharArray();
            Array.Reverse(ch);

          rev = new string(ch);
          bool b = palindrome.Equals(rev, StringComparison.OrdinalIgnoreCase);
          if (b == true)
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
