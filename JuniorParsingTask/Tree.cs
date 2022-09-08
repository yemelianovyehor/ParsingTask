using System.Collections.Generic;

namespace JuniorParsingTask;

public class Tree
{
    public readonly Node Root;
    public int Size { get; set; }

    public Tree(Node root)
    {
        Root = root;
    }


    //  Checks wether the tree has a node with given value
    //  If it does - return true and out the node
    //  If not - return false and Root
    public bool TryGetNode(string value, out Node outNode)
    {
        outNode = this.Root;
        Stack<Node> nodes = new Stack<Node>();
        nodes.Push(this.Root);
        while(nodes.Count>0)
        {
            var node = nodes.Pop();
            if(node.Value == value)
            {
                outNode = node;
                return true;
            }
            if(node.Children.Count != 0){
                foreach (var child in node.Children)
                {
                    nodes.Push(child);
                }
            }
        }
        return false;
    }
}