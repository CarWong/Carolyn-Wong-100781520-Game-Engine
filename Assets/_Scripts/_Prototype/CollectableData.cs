using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CollectableData")]
public class CollectableData : ScriptableObject
{
    public string _name;
    public int _score;
    public GameObject _prefab;
}
