﻿using System.Collections;

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
        public int IndexOf(Object value)
        {
                for (int i = 0; i < InnerArray.Length; i++)
                    if(GetValue(i).Equals(value))
                        return i;
                return -1;
        }
    }
}

