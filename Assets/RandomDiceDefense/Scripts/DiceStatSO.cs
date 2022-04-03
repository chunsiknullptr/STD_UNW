using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DiceStat", order = 1)]
public class DiceStatSO : ScriptableObject
{
    public int Level; // ���� ������ �ö� ��ġ��
    public enum Elemental
    {
        None,
        Fire,
        Water,
        Wind
    }

    public Elemental elemental;
    public float howFrequencyTimeForBullet; // �ҷ��� ���� �ֱ�� �������
    public float bulletDamage;
}

