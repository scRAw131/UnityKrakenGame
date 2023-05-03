using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats_", menuName = "CharacterData/Player")]
public class PlayerStats : ScriptableObject
{
    [Header("Attributes")]
    [SerializeField] private string _name;
    [SerializeField] private CharacterClass _characterClass = CharacterClass.None;
    [SerializeField] private int _characterLevel = 1;
    private int _characterExp = 0;
    [SerializeField] public int EXP => _characterExp;

    [Header("Ability Stats")]
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxMana;
    [SerializeField][Tooltip("Physical Attack")] private int _attackPower;
    [SerializeField][Tooltip("Physical Defense")] private int _toughness;
    [SerializeField][Tooltip("Magical Attack")] private int _magicPower;
    [SerializeField][Tooltip("Magical Defense")] private int _resilience;
    [SerializeField][Tooltip("Determines Turn Order")] private int _speed;

    //Public Exposing
    public string Name => _name;
    public CharacterClass Class => _characterClass;
    public int Level => _characterLevel;
    public int HP => _maxHealth;
    public int MP => _maxMana;
    public int Attack =>_attackPower;
    public int Toughness =>_toughness;
    public int Magic => _magicPower;
    public int Resilience => _resilience;
    public int Speed => _speed;
}
