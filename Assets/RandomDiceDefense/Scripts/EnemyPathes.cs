using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathes : MonoBehaviour
{
    [SerializeField]
    List<GameObject> pathes = new List<GameObject>();
    public List<GameObject> Pathes => pathes;

}
