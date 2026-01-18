using UnityEngine;

public class Node : MonoBehaviour
{
    [Tooltip("Nodes where the flow of sparks come into from")]
    public Node[] InNodes;

    [Tooltip("Nodes where the flow of sparks goes out to")]
    public Node[] OutNodes;

    [Tooltip("Can also be considered as a 'CanTraverse' flag")]
    public bool IsClosed;
    
    // number of closed nodes in the out list
    public int NumClosedOutNodes
    {
        get
        {
            int count = 0;
            foreach (Node n in OutNodes)
            {
                // if node is closed, add 1. if not, don't count it.
                count += n.IsClosed ? 1 : 0;
            }
            return count;
        }
    }
}