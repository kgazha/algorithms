namespace ConsoleApp;

public class Node<TValue>
{
    public TValue Value { get; }
    public Node<TValue> Next { get; set; }

    public Node(TValue value, Node<TValue> next)
    {
        Value = value;
        Next = next;
    }

    public override string? ToString()
    {
        return Value?.ToString();
    }
}

public static class CustomLinkedList
{
    public static Node<TValue> GetNodeByIndex<TValue>(Node<TValue> head, int index)
    {
        while (index != 0)
        {
            head = head.Next;
            index--;
        }

        return head;
    }

    public static Node<TValue> InsertNode<TValue>(Node<TValue> head, int index, TValue value)
    {
        var newNode = new Node<TValue>(value, head);
        if (index == 0)
        {
            return newNode;
        }

        var node = GetNodeByIndex(head, index - 1);
        newNode.Next = node.Next;
        node.Next = newNode;
        return head;
    }
}