using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDice : MonoBehaviour
{
    [SerializeField]
    DiceStatSO stat;

    // 총알을 x초에 한번씩 발사하는 기능을 가지고 있음.
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
        accTime += Time.deltaTime; // 0.016 정도 된다, 60frame일때
        if (accTime > stat.howFrequencyTimeForBullet)
        {
            // 가장 맨 앞에 있는 적을 타겟으로,
            var enemys = FindObjectsOfType<Enemy>();
            List<Enemy> enemyList = new List<Enemy>();
            enemyList.AddRange(enemys);
            enemyList.Sort(SortByFront);

            // 예외처리
            if (enemyList.Count == 0 || enemyList[0] == null)
                return;

            // 총알 발사!
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

        // 여기서부턴 같을 때
        // 목적지까지의 거리를 알아야 한다.
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
