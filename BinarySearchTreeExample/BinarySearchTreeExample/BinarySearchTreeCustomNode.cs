namespace BinarySearchTreeExample
{
    public class BinarySearchTreeCustomNode<T> where T : IComparable<T>
    {
        public T Value { get; private set; }

        public BinarySearchTreeCustomNode<T>? Left { get; private set; }

        public BinarySearchTreeCustomNode<T>? Right { get; private set; }

        public BinarySearchTreeCustomNode(T value)
        {
            Value = value;
            Left = Right = null;
        }

        public void Add(T value)
        {
            if (value.CompareTo(Value) < 0)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTreeCustomNode<T>(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinarySearchTreeCustomNode<T>(value);
                }
                else
                {
                    Right.Add(value);
                }
            }
        }

        public IEnumerable<T> TraverseInorder()
        {
            if (Left != null)
            {
                foreach (var subNode in Left.TraverseInorder())
                {
                    yield return subNode;
                }
            }

            yield return Value;

            if (Right != null)
            {
                foreach (var subNode in Right.TraverseInorder())
                {
                    yield return subNode;
                }
            }
        }

        public IEnumerable<T> TraversePreorder()
        {
            yield return Value;

            if (Left != null)
            {
                foreach (var subNode in Left.TraversePreorder())
                {
                    yield return subNode;
                }
            }

            if (Right != null)
            {
                foreach (var subNode in Right.TraversePreorder())
                {
                    yield return subNode;
                }
            }
        }

        public IEnumerable<T> TraversePostorder()
        {
            if (Left != null)
            {
                foreach (var subNode in Left.TraversePostorder())
                {
                    yield return subNode;
                }
            }

            if (Right != null)
            {
                foreach (var subNode in Right.TraversePostorder())
                {
                    yield return subNode;
                }
            }

            yield return Value;
        }
    }
}
