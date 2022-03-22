using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    class Array<T>:ICloneable,IEnumerator<T>
    {
        protected T[] InnerArray { get; set; }
        public int Length => InnerArray.Length;

        public T Current => throw new NotImplementedException();

        object System.Collections.IEnumerator.Current => throw new NotImplementedException();

        public Array(int defaultSize = 16)
        {
            InnerArray = new T[defaultSize];//fixed sized

        }

        public Array(params T[] sourceArray) : this(sourceArray.Length)
        {
            System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
        }
        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException("index");
            return InnerArray[index];
        }
        public void SetValue(T value, int index)
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
        public int IndexOf(Object value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
                if (GetValue(i).Equals(value))
                    return i;
            return -1;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
