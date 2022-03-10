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

        // 위치는 -2 ~ 2, -2 ~ 2 
        // 생성할 때 위치 랜덤
        // 숙제로 내드림

        Debug.Log("Dice Generate End");
    }
}