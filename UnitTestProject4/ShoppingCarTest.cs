using FluentAssertions;
using HarryPotter;
using Xunit;

namespace UnitTestProject4
{
    public class ShoppingCarTest
    {
        [Theory]
        [InlineData(2, 190)]
        [InlineData(3, 270)]
        [InlineData(4, 320)]
        [InlineData(5, 375)]
        public void Test_GetResultl(int count, double expected)
        {
            //Araange
            var actual = 0d;
            ShoppingCar myCar = new ShoppingCar();

            //Act            
            actual = myCar.GetResult(count);


            //Arrert
            Assert.Equal(expected, actual);
        }
    }
}
