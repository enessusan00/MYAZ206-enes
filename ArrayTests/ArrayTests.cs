using Datastructures.Array;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void CheckArrayStructures(int deafultSize)
        {

            var array = new Array(deafultSize);
            Assert.Equal(deafultSize, array.Length);
        }

    }
}