using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DiceStat", order = 1)]
public class DiceStatSO : ScriptableObject
{
    public int Level; // 눈금 갯수가 올라감 합치면
    public enum Elemental
    {
        None,
        Fire,
        Water,
        Wind
    }

    public Elemental elemental;
    public float howFrequencyTimeForBullet; // 불렛을 몇초 주기로 사용할지
    public float bulletDamage;
}

