namespace Datastructures.Array
{

    public class Array
    {
        private Object[] innerArray { get; set; }
        public int   Length => innerArray.Length;

        public Array(int defaultSize=16)
        {
            innerArray = new Object[defaultSize];//fixed sized

        }

    }
}