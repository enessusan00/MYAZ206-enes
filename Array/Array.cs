using System.Collections;

namespace Datastructures.Array
{

    public class Array:ICloneable,IEnumerable
    {
        private Object[] InnerArray { get; set; }
        public int   Length => InnerArray.Length;

        public Array(int defaultSize=16)
        {
            InnerArray = new Object[defaultSize];//fixed sized

        }
        public Array(params Object[] sourceArray):this(sourceArray.Length)
        {
            System.Array.Copy(sourceArray,InnerArray,  sourceArray.Length);
        }
        public Object GetValue(int index)
        {
            if (!(index>=0 && index<InnerArray.Length))
                throw new ArgumentOutOfRangeException("index");
            return InnerArray[index];
        }
        public void SetValue(Object value,int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            if (value == null)
                throw new ArgumentNullException();
            InnerArray[index] = value;

        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomArrayEnumerator(InnerArray);
        }
    }

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