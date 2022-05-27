using Xunit;

namespace TDD.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_EmptyString_returnZero()
        {
            var stringCalculator = new StringCalculator();
            Assert.Equal(0, stringCalculator.Add(string.Empty));
        }
    }
}
