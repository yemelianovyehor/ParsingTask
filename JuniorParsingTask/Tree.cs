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

    public bool TryGetNode(string value, out Node outNode)
    {
        outNode=null;
        if(this.Root!= null){
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(this.Root);
            while(nodes.Count>0)
            {
                var node = nodes.Pop();
                if(node.Value==value)
                {
                    outNode=node;
                    return true;
                }
                if(node.Children.Count!=0){
                    foreach (var child in node.Children)
                    {
                        nodes.Push(child);
                    }
                }
            }
        }
        return false;
    }
}