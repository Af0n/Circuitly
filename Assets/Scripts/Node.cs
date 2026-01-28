using System.Collections;
using UnityEngine;

public class Node : MonoBehaviour
{
    [Tooltip("Nodes where the flow of sparks come into from")]
    public ArrayList InNodes;

    [Tooltip("Nodes where the flow of sparks goes out to")]
    public ArrayList OutNodes;

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

    private void Awake()
    {
        // initialize fields
        InNodes = new();
        OutNodes = new();
    }

    public void AddNode(Node n, bool isIn)
    {
        // section for adding to InNodes
        if (isIn)
        {
            // don't add node if it already is in list
            if (InNodes.Contains(n))
            {
                Debug.Log($"{name} already contains {n.name} in InNodes");
                return;
            }

            // nodes can only be in or out, not both
            if (OutNodes.Contains(n))
            {
                Debug.Log($"{name} already contains {n.name} in OutNodes");
                return;
            }

            InNodes.Add(n);
            return;
        }

        // section for adding to OutNodes

        // don't add node if it already is in list
        if (OutNodes.Contains(n))
        {
            Debug.Log($"{name} already contains {n.name} in OutNodes");
            return;
        }

        // nodes can only be in or out, not both
        if (InNodes.Contains(n))
        {
            Debug.Log($"{name} already contains {n.name} in InNodes");
            return;
        }

        OutNodes.Add(n);
    }

    public void RemoveNode(Node n, bool isIn)
    {
        if (isIn)
        {
            InNodes.Remove(n);
            return;
        }

        OutNodes.Remove(n);
    }
}