using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TETRIS
{
    /*
     * TETRIS 
        1. Block Manager - Generate Block when no activated Block there
        // active������ ���� ������ ���� ����,

        2. Block - State - active - move down
        // ���� ���°� �ְ�, ��Ƽ�� ������ ���� �ڵ����� 1�ʿ� �ѹ��� ������
        // ���� ������ �� ���� ���°� �Ǹ�, Ȱ��ȭ�� Ǯ���� ��Ȱ��ȭ ���°� ��.
        // ��Ȱ��ȭ ������ ���� �̵��� �� ����.

        3. direction input arrow -> move block
        // ��ǲ�� �޾Ƽ� ���� �Ǵ� ������ Ű�� �����, ���� ���� �Ǵ� ���������� �̵�
        
     */
    public class TetrisGameManager : MonoBehaviour
    {
        public Block activatedBlock;
        public BlockMaker blockMaker;

        public static TetrisGameManager Instance;
        
        // ����,
        private void Awake()
        {
            Instance = this;
        }
        private void Start()
        {
            
        }

        private void Update()
        {
            // input ����
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // �ަU Ű ������
                // ���� Activated ���� ���� ���� ���¸� Activated ���·� ������ ��� �Ѵ�.
                // ���� Activated ���� ���� ���¸� None �Ѵ�.
                // activatedBlock�� ���� ���ο� ������ ��ü�� �ش�.

                var leftBlock = this.activatedBlock.GetLeftBlock();
                if (leftBlock != null)
                    leftBlock.state = Block.State.Active;

                // �ؾ� �� �� ������
                // �� ¥�ּ���
            }
            //else(Input.Ge...)


        }

        // ��,
    }
}
