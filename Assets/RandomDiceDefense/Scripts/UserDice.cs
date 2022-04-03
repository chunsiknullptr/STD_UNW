using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDice : MonoBehaviour
{
    [SerializeField]
    DiceStatSO stat;

    // �Ѿ��� x�ʿ� �ѹ��� �߻��ϴ� ����� ������ ����.
    public GameObject bulletPrefab;
    public Enemy targetEnemy;
    float accTime = 0;
    
    // threshold
    // Update is called once per frame
    void Update()
    {
        TryCheckAndShoot();
    }

    void TryCheckAndShoot()
    {
        accTime += Time.deltaTime; // 0.016 ���� �ȴ�, 60frame�϶�
        if (accTime > stat.howFrequencyTimeForBullet)
        {
            // ���� �� �տ� �ִ� ���� Ÿ������,
            var enemys = FindObjectsOfType<Enemy>();
            List<Enemy> enemyList = new List<Enemy>();
            enemyList.AddRange(enemys);
            enemyList.Sort(SortByFront);

            // ����ó��
            if (enemyList.Count == 0 || enemyList[0] == null)
                return;

            // �Ѿ� �߻�!
            var clonedBulletGO = GameObject.Instantiate(bulletPrefab);
            var clonedBullet = clonedBulletGO.GetComponent<Bullet>();

            targetEnemy = enemyList[0];
            clonedBullet.SetTarget(targetEnemy.gameObject);
            clonedBullet.SetDamage(this.stat.bulletDamage);
            accTime = 0;

            clonedBullet.transform.position = this.transform.position;
        }
    }

    private int SortByFront(Enemy x, Enemy y)
    {
        if(x.currentPathIndex> y.currentPathIndex)
        {
            return -1;
        }
        else if(x.currentPathIndex < y.currentPathIndex)
        {
            return 1;
        }

        // ���⼭���� ���� ��
        // ������������ �Ÿ��� �˾ƾ� �Ѵ�.
        var remainXDistance = x.GetRemainDistance();
        var remainYDistance = y.GetRemainDistance();
        if(remainXDistance < remainYDistance)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
