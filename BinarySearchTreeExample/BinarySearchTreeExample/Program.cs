namespace BinarySearchTreeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTreeCustom<int> tree = new BinarySearchTreeCustom<int>();
            tree.Add(22);
            tree.Add(7);
            tree.Add(1);
            tree.Add(10);
            tree.Add(50);
            tree.Add(34);
            tree.Add(90);

            foreach (int i in tree.Root.TraverseInorder())
            {
                Console.WriteLine(i);
            }
        }
    }
}