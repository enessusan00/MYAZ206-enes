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
            

    }
}
