using System.Collections;

namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>:IEnumerable<T>
    {
        public int Count { get; private set; }
        public DbNode<T> Head { get; private set; }
        public DbNode<T> Tail { get; private set; }
        
        private bool isHeadNull => Head == null;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;

        }
        public DoublyLinkedList(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                AddFirt(item);
            }
        }
        public void AddFirt(T value)
        {
            var newNode= new DbNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
                return;
            }
            newNode.Next= Head;
            Head.Prev= newNode;
            Head = newNode;
            return;
        }
        public void AddLast(T value)
        {
            var newNode=new DbNode<T>(value);
            if(isHeadNull)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
                Count++;
                return;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}