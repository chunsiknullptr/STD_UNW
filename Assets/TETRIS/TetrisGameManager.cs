using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TETRIS
{
    /*
     * TETRIS 
        1. Block Manager - Generate Block when no activated Block there
        // active상태인 블럭이 없으면 블럭을 생성,

        2. Block - State - active - move down
        // 블럭은 상태가 있고, 액티브 상태인 블럭은 자동으로 1초에 한번씩 내려옴
        // 블럭은 움직일 수 없는 상태가 되면, 활성화가 풀리고 비활성화 상태가 됨.
        // 비활성화 상태인 블럭은 이동할 수 없음.

        3. direction input arrow -> move block
        // 인풋을 받아서 왼쪽 또는 오른쪽 키를 누루면, 블럭이 왼쪽 또는 오른쪽으로 이동
        
     */
    public class TetrisGameManager : MonoBehaviour
    {
        public Block activatedBlock;
        public BlockMaker blockMaker;

        public static TetrisGameManager Instance;
        
        // 시작,
        private void Awake()
        {
            Instance = this;
        }
        private void Start()
        {
            
        }

        private void Update()
        {
            // input 관련
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // 왼쪾 키 눌리면
                // 현재 Activated 블럭의 왼쪽 블럭의 상태를 Activated 상태로 변경해 줘야 한다.
                // 현재 Activated 였던 블럭의 상태를 None 한다.
                // activatedBlock의 값을 새로운 블럭으로 대체해 준다.

                var leftBlock = this.activatedBlock.GetLeftBlock();
                if (leftBlock != null)
                    leftBlock.state = Block.State.Active;

                // 해야 될 일 더있음
                // 더 짜주세요
            }
            //else(Input.Ge...)


        }

        // 끝,
    }
}
