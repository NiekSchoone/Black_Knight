using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking;

    private float attackTimer;
    private float attackCooldown;

    //private MeleeAttack attack;
    private Animator animator;

	void Start ()
    {
        attackTimer = 0;
        attackCooldown = 1f;

        attacking = false;

        //attack = GetComponent<MeleeAttack>();
        animator = GetComponent<Animator>();
    }
	
	void Update ()
    {
	    if(Input.GetKey("space") && !attacking)
        {
            attacking = true;
            attackTimer = attackCooldown;
            //attack.AttackTrue();
        }

        if(attacking)
        {
            if(attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }else
            {
                attacking = false;
                //attack.AttackFalse();
            }
        }
        animator.SetBool("Attacking", attacking);
	}
}
