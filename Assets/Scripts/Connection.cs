using UnityEngine;

public class Connection : MonoBehaviour
{
    // two nodes that make up the connection
    public Node NodeA;
    public Node NodeB;

    // normal flow is NodeA -> NodeB
    public bool IsReversed;

    // true = traversable, false = cannot
    public bool IsClosed;
}
