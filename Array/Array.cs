using System.Collections;

namespace Datastructures.Array
{
    public class Array:ICloneable,IEnumerable
    {
        protected Object[] InnerArray { get; set; }
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
    public class ArrayList : Datastructures.Array.Array
    {
        private int position;
        public int Count=> position;
        public ArrayList(int defaultSize=2):base(defaultSize)
        {
            position = 0;
        }
        public void Add(Object value)
        {
            if(position==Length)
            {
                DoubleArray();
            }
            if (position<Length)
            {
                InnerArray[position] = value;
                position++;
                return;
            }
            throw new Exception();

        }

        private void DoubleArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length*2];
                System.Array.Copy(InnerArray,temp,InnerArray.Length);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

