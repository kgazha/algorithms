using ConsoleApp;


void NewNode()
{
    var node3 = new Node<string>("node3", null);
    var node2 = new Node<string>("node2", node3);
    var node1 = new Node<string>("node1", node2);
    var node0 = new Node<string>("node0", node1);

    var result = CustomLinkedList.GetNodeByIndex(node0, 1);
    Console.WriteLine(result);
    node0 = CustomLinkedList.InsertNode(node0, 1, "NewNode");
    Console.WriteLine(node0.Next);
}

