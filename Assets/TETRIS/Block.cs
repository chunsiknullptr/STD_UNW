using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public bool IsActivated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsActivated)
        {
            var renderer = GetComponentInChildren<Renderer>();
            renderer.material.color = Color.red;
        }
        else
        {
            var renderer = GetComponentInChildren<Renderer>();
            renderer.material.color = Color.white;
        }
    }
}
