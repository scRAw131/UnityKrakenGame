using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    //Set condition on which exp is gained. In this case it is by hitting Space
    //Could be a quest completion, or by defeating an enemy
    [SerializeField] private PlayerStats _stats;
    private int _expAmount = 10;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("+" + _expAmount + " EXP to " + _stats.Name);
            _stats.addEXP(_expAmount);
        }
    }


}
