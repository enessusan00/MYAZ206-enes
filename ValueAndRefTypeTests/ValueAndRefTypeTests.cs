
using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndRefTypeTests
{
    public class ValueAndRefTypeTests
    {
        [Fact]
        public void RefTypeTest()
        {
            //Arrange
            var p1 = new ReferenceType
            {
                X = 1,
                Y = 2
            };
            var p2 = p1;
            //Act
            p1.X = 20;
            //Assert
            Assert.Equal(p1.X, p2.X);
        }
        [Fact]
        public void ValueTypeTest()
        {
            //Arrange
            var p1 = new ValueAndReferenceTypes.ValueType
            {
                X = 1,
                Y = 2
            };
            var p2 = p1;
            //Act
            p1.X = 20;
            //Assert
            Assert.NotEqual(p1.X, p2.X);
        }
    }
}