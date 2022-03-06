using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    // 블럭메이커가 하는 일
    // Block을 초기에 생성해 주는 일

    [SerializeField]
    int mapX = 5;

    [SerializeField]
    int mapY = 10;

    [SerializeField] // 언리얼 - 아키타입, 블루프린트, 유니티 - prefab
    GameObject prefabBlock;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < mapY; ++i)
        {
            for(int k =  0; k < mapX; ++k)
            {
                var newInstanced = GameObject.Instantiate(prefabBlock);               
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
