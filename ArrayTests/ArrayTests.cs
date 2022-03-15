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
        [Fact]
        public void Check_array_with_params()
        {
            //arrange|act
            var arr= new Datastructures.Array.Array(1,2,3);
            //assert
            Assert.Equal(3, arr.Length);
        }
        [Fact]
        public void Get_Set_value_Array()
        {
            //arrange
            var arr = new Datastructures.Array.Array();
            //act
            arr.SetValue(10, 0);
            arr.SetValue(20, 1);
            arr.SetValue(30, 2);
            //assert
            Assert.Equal(10,arr.GetValue(0));
            Assert.Equal(20, arr.GetValue(1));
            Assert.Equal(30, arr.GetValue(2));
            Assert.Null(arr.GetValue(3));
        }
    }
}