using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    [SerializeField]
    Animator player;
    void Update()
    {
        meleeAttack();
    }
    
    void meleeAttack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.SetTrigger("AttackMelee");
        }
    }
}
