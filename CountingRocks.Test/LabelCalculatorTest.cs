namespace CountingRocks.Test
{
    public class LabelCalculatorTest
    {
        [Theory]
        [InlineData(13, 17)]
        [InlineData(36123011, 277872985)]
        public void Test1(long input, long expected)
        {
            //arrange
            ILabelCalculator label = new LabelCalculator();

            //act
            long actual = label.Calculate(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}