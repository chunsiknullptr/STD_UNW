using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyStatSO enemyStatSO; // 64��Ʈ �������δ� 8����Ʈ

    // Enemy�� ���� ���� �����δ�.
    EnemyPathes enemyPathes;

    // ���� �������� �ε���
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
        // �Ѿ�, �Ѿ� ������,
        var allBullet = FindObjectsOfType<Bullet>();
        foreach(var bullet in allBullet)
        {
            float rad1 = bullet.GetRad;
            float rad2 = this.rad;

            var diff = bullet.transform.position - this.transform.position;

            // ���� �Ÿ��� ������ �պ��� ������ �浹
            bool isCollisionWithBullet = rad1 + rad2 > diff.magnitude;
            // �Ѿ��� �ε��� Update�� timing,
            if (isCollisionWithBullet)
            {
                // �Ѿ��� �ε��� �ٸ�?
                Hp -= bullet.GetDamage;
                if (Hp <= 0)
                {
                    // ���� ��
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
