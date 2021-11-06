using Bubelinez.Utils;
using SFML.Graphics;
using SFML.System;
using Xunit;

namespace RPG.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnToBasic()
        {
            var result = Intersection.CheckPointRectIntersect(new Vector2f(15, 15), new FloatRect(10, 10, 40, 20));
            Assert.True(result);
        }
    }
}
