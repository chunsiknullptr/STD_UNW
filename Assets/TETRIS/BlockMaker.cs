using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    // 블럭메이커가 하는 일
    // Block을 초기에 생성해 주는 일

    [SerializeField]
    public int mapX = 5;

    [SerializeField]
    public int mapY = 10;

    [SerializeField] // 언리얼 - 아키타입, 블루프린트, 유니티 - prefab
    GameObject prefabBlock;

    List<List<Block>> blocks = new List<List<Block>>();
    public static List<Block> tempBlocks = new List<Block>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < mapY; ++i)
        {
            // blocks에 여기서 생성된 블럭들을 잘 넣어주세요.
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
        // active상태인 블럭이 없으면 블럭을 생성,
        if (TETRIS.TetrisGameManager.Instance.activatedBlock == null)
        {
            //활성화 상태인 블럭이 없으면 블럭을 생성
            TETRIS.TetrisGameManager.Instance.activatedBlock = MakeNewBlock();
        }
    }
    public Block MakeNewBlock()
    {
        // 다시 짜주세요. blocks 기반으로, tempBlocks는 지워주세요
        tempBlocks[tempBlocks.Count - 3].state = Block.State.Active;
        return tempBlocks[tempBlocks.Count - 3];
    }
}
