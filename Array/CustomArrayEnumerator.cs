using System.Collections;

namespace Datastructures.Array
{
    public class CustomArrayEnumerator : IEnumerator
    {
        public Object[] _array;
        private int index=-1;
        public CustomArrayEnumerator(Object[] array)
        {
            _array = array;
        }

        public object Current => _array[index];
        public bool MoveNext()
        {
            if (index<_array.Length-1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}