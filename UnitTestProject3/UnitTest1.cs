using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

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
