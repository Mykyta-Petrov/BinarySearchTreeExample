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

        public IEnumerable<T> TraverseLevelOrder()
        {
            Queue<BinarySearchTreeCustomNode<T>> queue = new Queue<BinarySearchTreeCustomNode<T>>();

            if (Root != null)
            {
                queue.Enqueue(Root);
                
                while (queue.Count > 0)
                {
                    BinarySearchTreeCustomNode<T> node = queue.Dequeue();

                    yield return node.Value;

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }
        }
    }
}
