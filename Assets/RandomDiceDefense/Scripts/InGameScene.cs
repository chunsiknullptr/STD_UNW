using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScene : MonoBehaviour
{
    static BaseScene active;
    public static T GetActive<T>() where T : BaseScene
    {
        return active as T;
    }
    protected virtual void Awake()
    {
        active = this;
    }
}

// �긦 ���ؼ� ����Ѵ�.
public class InGameScene : BaseScene
{
    [SerializeField]
    GameObject prefabDice;
    public GameObject GetPrefabDice => prefabDice;

    [SerializeField]
    GameObject prefabUserField;
    public GameObject GetPrefabUserField => prefabUserField;

    public GameObject diceStartPosition;

    // ����Ƽ �����ͷ� ���� �޾Ƶ��� ������!
    [SerializeField]
    EnemyPathes enemyPathes;
    public EnemyPathes GetEnemyPathes => enemyPathes;

    protected override void Awake()
    {
        base.Awake();    
        Instantiate(prefabUserField);
    }
}
