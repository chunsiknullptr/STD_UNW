using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ũ��Ʈ���̺� ������Ʈ��, ��������� ���͸� ���ְ�, �б��������� �������.
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
