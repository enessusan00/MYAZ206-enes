using LinkedList.DoublyLinkedList;
using Xunit;

namespace LinkedListTests
{
    public class DoublyLinkedListTest
    {
        private DoublyLinkedList<char> _list;
        public DoublyLinkedListTest()
        {
            _list = new DoublyLinkedList<char> (new char[] {'a','z'});
        }
        [Theory]
        [InlineData('f')]
        public void AddFirstTest(char value)
        {
            //act
            _list.AddFirt(value);
            Assert.Equal(value, _list.Head.Value);
        }
        [Theory]
        [InlineData('ý')]
        [InlineData('a')]
        [InlineData('k')]
        [InlineData('e')]
        [InlineData('i')]
        public void AddLast_Test(char value)
        {
            // a z [value]
            // act
            _list.AddLast(value);
            var tailValue = _list.Tail.Value;

            // Assert
            Assert.Equal(value, tailValue);

            Assert.Collection(_list,
                item => Assert.Equal(item, 'a'),       // O(1)
                item => Assert.Equal(item, 'z'),       // O(n)
                item => Assert.Equal(item, value));    // O(1)
        }
    }
}