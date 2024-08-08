using UnitTestingTask;

namespace UnitTestingTaskTests
{
    public class UnitTests
    {
        [Fact]
        public void MaxUnequalConsecutiveCharacters_Test_EmptyString()
        {
            // Arrange
            string input = "";

            // Act
            int result = Program.MaxUnequalConsecutiveCharacters(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxUnequalConsecutiveCharacters_Test_AllSameCharacters()
        {
            // Arrange
            string input = "aaaaaa";

            // Act
            int result = Program.MaxUnequalConsecutiveCharacters(input);

            // Assert
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData("abcde", 5)]
        [InlineData("abcddefghiii", 6)]
        public void MaxUnequalConsecutiveCharacters_Test_MixedCharacters(string input, int expectedResult)
        {
            // Arrange
            // Act
            int result = Program.MaxUnequalConsecutiveCharacters(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MaxConsecutiveIdenticalLetters_Test_EmptyString()
        {
            // Arrange
            string input = "";

            // Act
            int result = Program.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("aabbbccdde", 3)]
        [InlineData("a123bb4", 2)]
        [InlineData("a", 1)]
        public void MaxConsecutiveIdenticalLetters_Test_MixedLetters(string input, int expectedResult)
        {
            // Arrange
            // Act
            int result = Program.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MaxConsecutiveIdenticalLetters_Test_NoLetters()
        {
            // Arrange
            string input = "123456";

            // Act
            int result = Program.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxConsecutiveIdenticalDigits_Test_EmptyString()
        {
            // Arrange
            string input = "";

            // Act
            int result = Program.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1122334455", 2)]
        [InlineData("12345", 1)]
        [InlineData("12223445", 3)]
        [InlineData("a1bbc2222", 4)]
        public void MaxConsecutiveIdenticalDigits_Test_MixedDigits(string input, int expectedResult)
        {
            // Arrange
            // Act
            int result = Program.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MaxConsecutiveIdenticalDigits_Test_NoDigits()
        {
            // Arrange
            string input = "abcdef";

            // Act
            int result = Program.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.Equal(0, result);
        }
    }
}