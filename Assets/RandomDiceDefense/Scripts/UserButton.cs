using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserButton : MonoBehaviour
{
    // Transform �� ��ü
    // ����ü�� class ���̰� ����

    // ����ü�� �������� ����, �Լ��� ����, ���ÿ� ����
    // Class �������� ����, �Լ��� ����, ���� ����

    public struct TestStruct
    {
        public int a;
        public int b;

    }

    public void OnButtonGenerateUserDice()
    {
        var scene = InGameScene.GetActive<InGameScene>();

        Debug.Log("Dice Generate Start");

        // ���ӿ�����Ʈ ��� �߿�, ��������, PrefabDice �������!!!, �� ������ ��ü�� clonedDice�� ���� �־���!
        var clonedDice = GameObject.Instantiate(scene.GetPrefabDice);
        
        int RandomX = UnityEngine.Random.Range(-2, 3);
        int RandomY = UnityEngine.Random.Range(-2, 3);
        
        Vector2 RandomPos = new Vector2(RandomX, RandomY);
        clonedDice.transform.position = RandomPos;
        // ��ġ�� -2 ~ 2, -2 ~ 2 
        // ������ �� ��ġ ����
        // ������ ���帲

        Debug.Log("Dice Generate End");
    }
}
