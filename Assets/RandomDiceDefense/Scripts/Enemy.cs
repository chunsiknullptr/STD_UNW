using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy�� ���� ���� �����δ�.
    EnemyPathes enemyPathes;

    // ���� �������� �ε���
    public int currentPathIndex { get; private set; } = 0;
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

        // Vector �� ����
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

    public float GetRemainDistance()
    {
        var currentPos = this.transform.position;
        var currentPathPos = enemyPathes.Pathes[currentPathIndex].transform.position;
        var toVec = currentPathPos - currentPos;

        return toVec.magnitude;
    }
}
