namespace BinarySearchTreeExample
{
    public class BinarySearchTreeCustom<T> where T : IComparable<T>
    {
        public BinarySearchTreeCustomNode<T>? Root { get; private set; }

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeCustomNode<T>(value);
            }
            else
            {
                Root.Add(value);
            }
        }
    }
}
