using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Block : MonoBehaviour
{
    [ReadOnly]
    public int Index;
    public enum State
    {
        None,
        Active,
        Deactivated,
        WillDestroy
    }
    public State state = State.None;
    Renderer blockRenderer;
    // Start is called before the first frame update
    void Start()
    {
        blockRenderer = GetComponentInChildren<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.None:
                blockRenderer.material.color = Color.white;
                break;
            case State.Active:
            case State.Deactivated:
                blockRenderer.material.color = Color.red;
                break;
            case State.WillDestroy:
                blockRenderer.material.color = Color.blue;
                break;
        }
    }

    public Block GetLeftBlock()
    {
        if (this.Index - 1 < 0)
            return null;

        return BlockMaker.tempBlocks[this.Index - 1];
    }
}
