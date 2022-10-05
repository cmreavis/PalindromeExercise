using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("rotor", true)]
        [InlineData("baseball", false)]
        [InlineData("level", true)]
        [InlineData("deter", false)]
        [InlineData("antidisestablishmentarianism", false)]
        public void PalindromeTest(string word1, bool isPalindromeExpected)
        {
            //Arrange
            var pal = new Wordsmith();
            //Act
            var isPalindromeActual = pal.IsAPalindrome(word1);
            //Assert
            Assert.Equal(isPalindromeExpected, isPalindromeActual);

        }
    }
}
