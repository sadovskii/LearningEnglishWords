using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 12;
            var b = 13;
            a = b;
        }
    }
}
