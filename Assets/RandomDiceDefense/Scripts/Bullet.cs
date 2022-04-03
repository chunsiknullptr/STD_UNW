using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // bullet �ʿ��� ��    
    float speed;

    [SerializeField]
    float damage;
    public float GetDamage => damage;
    float rad;
    public float GetRad => rad;

    // �Ѿ��� ��ǥ��
    GameObject target;

    private void Start()
    {
        speed = Random.Range(3f, 6f);
        rad = this.GetComponent<SphereCollider>().radius;
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
        // �Ѿ��� ��ġ�� ��ǥ���� �������� ��� �̵��Ѵ�.        
        //��ǥ������ ����
        var toVec = target.transform.position - transform.position;

        //�Ѿ��� ��ġ��
        transform.position += toVec.normalized * speed * Time.deltaTime;
    }

    public void SetDamage(float bulletDamage)
    {
        damage = bulletDamage;
    }
}
