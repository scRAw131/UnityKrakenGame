using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private PlayerStats _stats;

    public PlayerStats Stats => _stats;

    private void Awake()
    {
        Debug.Log("Name: " + _stats.Name);
        Debug.Log("Class: " + _stats.Class);
        Debug.Log("Level: " + _stats.Level);
        Debug.Log("EXP: " + _stats.EXP);
        Debug.Log("HP: " + _stats.HP);
        Debug.Log("MP: " + _stats.MP);
        Debug.Log("Attack Power: " + _stats.Attack);
        Debug.Log("Toughness: " + _stats.Toughness);
        Debug.Log("Magic Power: " + _stats.Magic);
        Debug.Log("Resilience: " + _stats.Resilience);
        Debug.Log("Speed: " + _stats.Speed);

    }
}
