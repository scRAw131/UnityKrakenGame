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
    public int _characterExp = 0;

    [Header("Ability Stats")]
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxMana;
    [SerializeField][Tooltip("Physical Attack")] private int _attackPower;
    [SerializeField][Tooltip("Physical Defense")] private int _toughness;
    [SerializeField][Tooltip("Magical Attack")] private int _magicPower;
    [SerializeField][Tooltip("Magical Defense")] private int _resilience;
    [SerializeField][Tooltip("Determines Turn Order")] private int _speed;

    public void addEXP(int ExpValue)
    {
        _characterExp += ExpValue;
    }

    public void levelUP()
    {
        if(_characterClass == CharacterClass.Warrior)
        {
            if (_characterExp >= 50 * _characterLevel)
            {
                _characterLevel += 1;
                _maxHealth += 12;
                _maxMana += 2;
                _attackPower += 8;
                _toughness += 8;
                _resilience += 6;
                _speed += 2;
                levelUpMsg();
            }
        }
        if (_characterClass == CharacterClass.Mage)
        {
            if (_characterExp >= 50 * _characterLevel)
            {
                _characterLevel += 1;
                _maxHealth += 8;
                _maxMana += 12;
                _attackPower += 2;
                _toughness += 2;
                _magicPower += 12;
                _resilience += 3;
                _speed += 6;
                levelUpMsg();
            }
        }
        if (_characterClass == CharacterClass.Thief)
        {
            if (_characterExp >= 50 * _characterLevel)
            {
                _characterLevel += 1;
                _maxHealth += 9;
                _maxMana += 6;
                _attackPower += 9;
                _toughness += 4;
                _magicPower += 4;
                _resilience += 4;
                _speed += 9;
                levelUpMsg();
            }
        }
        if (_characterClass == CharacterClass.Cleric)
        {
            if (_characterExp >= 50 * _characterLevel)
            {
                _characterLevel += 1;
                _maxHealth += 10;
                _maxMana += 10;
                _attackPower += 8;
                _toughness += 8;
                _magicPower += 8;
                _resilience += 6;
                _speed += 2;
                levelUpMsg();
            }
        }
    }

    private void levelUpMsg()
    {
        Debug.Log(Name + " Leveled UP!");
        Debug.Log("EXP: " + EXP);
        Debug.Log("HP: " + HP);
        Debug.Log("MP: " + MP);
        Debug.Log("Attack Power: " + Attack);
        Debug.Log("Toughness: " + Toughness);
        Debug.Log("Magic Power: " + Magic);
        Debug.Log("Resilience: " + Resilience);
        Debug.Log("Speed: " + Speed);
        Debug.Log("-----------------------");
    }

    public void resetLevels()
    {
        if (_characterClass == CharacterClass.Warrior)
        {
            _characterExp = 0;
            _characterLevel = 1;
            _maxHealth = 30;
            _maxMana = 6;
            _attackPower = 18;
            _toughness = 20;
            _magicPower = 0;
            _resilience = 14;
            _speed = 3;
        }
        if (_characterClass == CharacterClass.Thief)
        {
            _characterExp = 0;
            _characterLevel = 1;
            _maxHealth = 18;
            _maxMana = 12;
            _attackPower = 22;
            _toughness = 12;
            _magicPower = 4;
            _resilience = 12;
            _speed = 18;
        }
        if (_characterClass == CharacterClass.Cleric)
        {
            _characterExp = 0;
            _characterLevel = 1;
            _maxHealth = 20;
            _maxMana = 20;
            _attackPower = 9;
            _toughness = 12;
            _magicPower = 18;
            _resilience = 12;
            _speed = 8;
        }
        if (_characterClass == CharacterClass.Mage)
        {
            _characterExp = 0;
            _characterLevel = 1;
            _maxHealth = 12;
            _maxMana = 24;
            _attackPower = 4;
            _toughness = 7;
            _magicPower = 30;
            _resilience = 8;
            _speed = 12;
        }
     }

    //Public Exposing
    public string Name => _name;
    public CharacterClass Class => _characterClass;
    public int Level => _characterLevel;
    public int EXP => _characterExp;
    public int HP => _maxHealth;
    public int MP => _maxMana;
    public int Attack =>_attackPower;
    public int Toughness =>_toughness;
    public int Magic => _magicPower;
    public int Resilience => _resilience;
    public int Speed => _speed;
}
