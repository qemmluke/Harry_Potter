using Xunit;
using FluentAssertions;

namespace UnitTestProject1
{

    public class ShoppingCarTest
    {
        [Fact]
        public void TesGetResult()
        {

            var a = 1;
            var b = 2;
            var c = 1;

            // Equal
            a.Should().Be(c);
            a.Should().NotBe(b);

        }
    }
}
