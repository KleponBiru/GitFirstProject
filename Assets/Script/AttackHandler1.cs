using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler1 : MonoBehaviour
{
    public Animator charAnimator;
    void Start()
    {
        charAnimator = GetComponent<Animator>();
    }

    void AttackNow()
    {
        charAnimator.SetTrigger("GoAttack");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AttackNow();
        }
    }
}
