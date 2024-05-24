using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("wow", true)]
        [InlineData("mom", true)]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("hey", false)]
        [InlineData("coding", false)]
        [InlineData("false", false)]   
        public void PalindromeTest(string word, bool expected)
        {
            var wordsmith = new Wordsmith();

            var actual = wordsmith.IsPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
