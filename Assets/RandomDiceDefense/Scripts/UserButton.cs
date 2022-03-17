using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserButton : MonoBehaviour
{
    // Transform 은 객체
    // 구조체랑 class 차이가 뭐냐

    // 구조체는 데이터의 모음, 함수의 모음, 스택에 쌓임
    // Class 데이터의 모음, 함수의 모음, 힙에 쌓임

    public struct TestStruct
    {
        public int a;
        public int b;

    }

    public void OnButtonGenerateUserDice()
    {
        var scene = InGameScene.GetActive<InGameScene>();

        Debug.Log("Dice Generate Start");

        // 게임오브젝트 기능 중에, 생성해줘, PrefabDice 기반으로!!!, 그 생성된 객체를 clonedDice에 집어 넣어줘!
        var clonedDice = GameObject.Instantiate(scene.GetPrefabDice);
        
        int RandomX = UnityEngine.Random.Range(-2, 3);
        int RandomY = UnityEngine.Random.Range(-2, 3);
        
        Vector2 RandomPos = new Vector2(RandomX, RandomY);
        clonedDice.transform.position = RandomPos;
        // 위치는 -2 ~ 2, -2 ~ 2 
        // 생성할 때 위치 랜덤
        // 숙제로 내드림

        Debug.Log("Dice Generate End");
    }
}
