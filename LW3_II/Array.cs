namespace LW3_II
{
    abstract class Array
    {
        public abstract int[] IntArray1 { get; set; }
        //public abstract int[,] IntArray2 { get; set; }
        //public abstract int[,,] IntArray3 { get; set; }

        public abstract void AddElement(Element el);
        public abstract void CreateArray(int n);
        public abstract void Show();
    }
}
