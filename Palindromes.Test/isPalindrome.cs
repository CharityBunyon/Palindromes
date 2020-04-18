using System;
using Xunit;

namespace Palindromes.Test
{
    public class isPalindrome
    {
        [Fact]
        public void is_stars_palindrome()
        {
            var palindrome = "stars";
            var rev = "srats";
            var expectedResulted = false;
            var palidromeChecker = new PalindromeChecker();

            var actualResult = palidromeChecker.Check(palindrome, rev);
            Assert.Equal(expectedResulted,actualResult);

        }
    }
}
