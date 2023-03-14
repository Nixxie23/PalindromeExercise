using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("", false)]
        [InlineData("meow", false)]
        [InlineData("wow", true)]
        [InlineData("woW", true)]
              
        
        public void IsAPalindromeTest(string testWord, bool expected)
        {
            var challenger = new WordSmith();
            bool actual = challenger.IsAPalindrome(testWord);
            Assert.Equal(expected, actual); 
        }
    }
}
