using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    // ������Ŀ�� �ϴ� ��
    // Block�� �ʱ⿡ ������ �ִ� ��

    [SerializeField]
    int mapX = 5;

    [SerializeField]
    int mapY = 10;

    [SerializeField] // �𸮾� - ��ŰŸ��, �������Ʈ, ����Ƽ - prefab
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
