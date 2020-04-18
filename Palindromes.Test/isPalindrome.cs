using System;
using Xunit;

namespace Palindromes.Test
{
    public class isPalindrome
    {
        [Fact]
        public void is_test1_palindrome()
        {
            var palindrome = "stars";
            var rev = "srats";
            var expectedResulted = false;
            var palidromeChecker = new PalindromeChecker();

            var actualResult = palidromeChecker.Check(palindrome, rev);
            Assert.Equal(expectedResulted,actualResult);

        }

        [Fact]
        public void is_test2_palindrome()
        {
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var rev = "!oakak uwak ov lil vokawU kak a, O";
            var expectedResulted = true;
            var palidromeChecker = new PalindromeChecker();

            var actualResult = palidromeChecker.Check(palindrome, rev);
            Assert.Equal(expectedResulted, actualResult);

        }

        [Fact]
        public void is_test3_palindrome()
        {
            var palindrome = "Some men interpret nine memos";
            var rev = "somem enin terpretni nem emos";
            var expectedResulted = true;
            var palidromeChecker = new PalindromeChecker();

            var actualResult = palidromeChecker.Check(palindrome, rev);
            Assert.Equal(expectedResulted, actualResult);

        }
    }
}
