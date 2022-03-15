namespace Datastructures.Array
{

    public class Array
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

    }
}