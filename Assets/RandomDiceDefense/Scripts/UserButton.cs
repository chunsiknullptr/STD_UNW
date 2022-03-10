using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserButton : MonoBehaviour
{
    public void OnButtonGenerateUserDice()
    {
        var scene = InGameScene.GetActive<InGameScene>();

        Debug.Log("Dice Generate Start");
        var clonedDice = GameObject.Instantiate(scene.GetPrefabDice);
        clonedDice.transform.position = scene.diceStartPosition.transform.position;

        // ��ġ�� -2 ~ 2, -2 ~ 2 
        // ������ �� ��ġ ����
        // ������ ���帲

        Debug.Log("Dice Generate End");
    }
}