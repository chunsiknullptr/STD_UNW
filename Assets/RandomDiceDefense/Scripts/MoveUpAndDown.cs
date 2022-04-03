using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    const int maxUpY = 1;
    const int minDownY = -1;
    int iDir = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * 3 * Time.deltaTime * iDir;
        if(transform.position.y > maxUpY)
        {
            iDir = -1;
        }

        if(transform.position.y < minDownY)
        {
            iDir = 1;
        }
    }
}
