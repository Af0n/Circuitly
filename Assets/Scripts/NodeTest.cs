using UnityEngine;

public class NodeTest : MonoBehaviour
{
    public Node TestA, TestB;

    private void Start()
    {
        TestA.AddNode(TestB, true);

        Debug.Log(TestA.InNodes[0]);
        TestA.AddNode(TestB, true);
    }
}
