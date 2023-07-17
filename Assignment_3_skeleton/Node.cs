namespace Assignment_3_skeleton
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }


        public Node(object data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}