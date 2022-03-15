using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayTests
{
    public class ArrayList
    {
        private Datastructures.Array.ArrayList _arrayList;
        public ArrayList()
        {
            _arrayList = new Datastructures.Array.ArrayList();
        }


        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        public void ArrayList_ctor_test(int defaultSize)
        {
            var arrList=new Datastructures.Array.ArrayList(defaultSize);
            Assert.Equal(defaultSize, arrList.Length);

        }
        [Fact]
        public void Array_Add()
        {
            for (int i = 0; i < 20; i++)
            {
                _arrayList.Add(i);
            }
            Assert.Equal(32,_arrayList.Length);
        }
            

    }
}
