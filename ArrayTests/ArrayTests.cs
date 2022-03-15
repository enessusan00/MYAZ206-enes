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
        [Fact]
        public void Array_Clone()
        {
            var arr = new Datastructures.Array.Array(1, 2, 3, 4, 5, 6);
            var clone = arr.Clone() as Datastructures.Array.Array;
            Assert.Equal(arr.Length, clone.Length);
            Assert.NotEqual(arr.GetHashCode(), clone.GetHashCode());
        }
        [Fact]
        public void Array_IEnumerable()
        {
            var arr = new Datastructures.Array.Array(10,20,31);

            string s = "";
            foreach (var item in arr)   
            {
                s+=item;
            }
            Assert.Equal("102031",s);
        }
    }
}