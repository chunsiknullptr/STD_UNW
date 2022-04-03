using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyStatSO enemyStatSO; // 64비트 기준으로는 8바이트

    // Enemy는 길을 따라서 움직인다.
    EnemyPathes enemyPathes;

    // 현재 목적지의 인데스
    public int currentPathIndex { get; private set; } = 0;
    float speed => enemyStatSO.GetSpeed;
    float Hp;
    float rad;

    private void Start()
    {
        enemyPathes = BaseScene.GetActive<InGameScene>().GetEnemyPathes;
        Hp = enemyStatSO.GetHP;
        rad = this.GetComponent<SphereCollider>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        // 총알, 총알 반지름,
        var allBullet = FindObjectsOfType<Bullet>();
        foreach(var bullet in allBullet)
        {
            float rad1 = bullet.GetRad;
            float rad2 = this.rad;

            var diff = bullet.transform.position - this.transform.position;

            // 둘의 거리가 반지름 합보다 작으면 충돌
            bool isCollisionWithBullet = rad1 + rad2 > diff.magnitude;
            // 총알이 부딛힌 Update의 timing,
            if (isCollisionWithBullet)
            {
                // 총알이 부딛혔 다면?
                Hp -= bullet.GetDamage;
                if (Hp <= 0)
                {
                    // 죽은 것
                    DestroyImmediate(gameObject);
                    return;
                }
            }
        }
        
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

    public float GetRemainDistance()
    {
        var currentPos = this.transform.position;
        var currentPathPos = enemyPathes.Pathes[currentPathIndex].transform.position;
        var toVec = currentPathPos - currentPos;

        return toVec.magnitude;
    }
}
