using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스크립트에이블 오브젝트는, 명시적으로 세터를 없애고, 읽기전용으로 만들거임.
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyStatSO")]
public class EnemyStatSO : ScriptableObject
{
    [SerializeField]
    int Level;
    public int GetLevel => Level;

    [SerializeField]
    float HP;
    public float GetHP => HP;

    [SerializeField]
    float speed;
    public float GetSpeed => speed;
}
