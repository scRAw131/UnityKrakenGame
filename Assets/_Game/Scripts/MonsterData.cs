using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData_", menuName = "UnitData/Monster")]
public class MonsterData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField] private string _name = "...";
    [SerializeField] private MonsterType _monsterType = MonsterType.None;
    [SerializeField][Range(0, 100)] private float _chanceToDropItem = 20;
    [SerializeField]
    [Tooltip("Radius size where monster will see the player")]
    [Range(0, 100)]
    private float _rangeOfAwareness = 10;

    [Header("Combat Steps")]
    [SerializeField] private int _damage = 1;
    [SerializeField] private int _health = 1;
    [SerializeField] private int _speed = 1;

    [Header("Dialogue")]
    [SerializeField]
    [Tooltip("Speaks dialogue when entering combat")]
    [TextArea()]
    private string _battleCry = "...";

    //Public Exposing (Can't be edited, but can be seen)
    public string Name => _name;
    public MonsterType MonsterType => _monsterType;
    public float RangeOfAwareness => _rangeOfAwareness;
    public int Damage => _damage;
    public int Health => _health;
    public string BattleCry => _battleCry;
}