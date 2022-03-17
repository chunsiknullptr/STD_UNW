using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // bullet 필요한 것    
    float speed;

    [SerializeField]
    float damage;

    // 총알의 목표물
    GameObject target;

    private void Start()
    {
        speed = Random.Range(3f, 6f);
    }

    public void SetTarget(GameObject inTarget)
    {
        target = inTarget;
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        // 총알의 위치는 목표물의 방향으로 계속 이동한다.        
        //목표물로의 방향
        var toVec = target.transform.position - transform.position;

        //총알의 위치는
        transform.position += toVec.normalized * speed * Time.deltaTime;
    }
}
