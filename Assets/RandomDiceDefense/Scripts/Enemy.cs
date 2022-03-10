using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy는 길을 따라서 움직인다.
    EnemyPathes enemyPathes;

    // 현재 목적지의 인데스
    int currentPathIndex = 0;
    [SerializeField]
    float speed = 3f;

    private void Start()
    {
        enemyPathes = BaseScene.GetActive<InGameScene>().GetEnemyPathes;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPathIndex >= enemyPathes.Pathes.Count)
        {
            currentPathIndex = 0;
            return;
        }

        // Vector 에 대해
        var currentPos = this.transform.position;
        var currentPathPos = enemyPathes.Pathes[currentPathIndex].transform.position;

        var toVec = currentPathPos - currentPos;
        var dirVec = toVec.normalized;

        transform.position += dirVec * Time.deltaTime * speed;
        if(toVec.magnitude < 0.5f)
        {
            currentPathIndex++;
        }
    }
}
