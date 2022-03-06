using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    // ������Ŀ�� �ϴ� ��
    // Block�� �ʱ⿡ ������ �ִ� ��

    [SerializeField]
    public int mapX = 5;

    [SerializeField]
    public int mapY = 10;

    [SerializeField] // �𸮾� - ��ŰŸ��, �������Ʈ, ����Ƽ - prefab
    GameObject prefabBlock;

    List<List<Block>> blocks = new List<List<Block>>();
    public static List<Block> tempBlocks = new List<Block>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < mapY; ++i)
        {
            // blocks�� ���⼭ ������ ������ �� �־��ּ���.
            for (int k =  0; k < mapX; ++k)
            {
                var newInstanced = GameObject.Instantiate(prefabBlock);
                newInstanced.transform.position = new Vector3(k*1.2f, i*1.2f, 0);

                var newBlock = newInstanced.GetComponent<Block>();
                newBlock.Index = tempBlocks.Count;
                tempBlocks.Add(newBlock);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 1.Block Manager - Generate Block when no activated Block there
        // active������ ���� ������ ���� ����,
        if (TETRIS.TetrisGameManager.Instance.activatedBlock == null)
        {
            //Ȱ��ȭ ������ ���� ������ ���� ����
            TETRIS.TetrisGameManager.Instance.activatedBlock = MakeNewBlock();
        }
    }
    public Block MakeNewBlock()
    {
        // �ٽ� ¥�ּ���. blocks �������, tempBlocks�� �����ּ���
        tempBlocks[tempBlocks.Count - 3].state = Block.State.Active;
        return tempBlocks[tempBlocks.Count - 3];
    }
}
