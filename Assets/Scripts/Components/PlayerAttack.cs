using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking;

    private float attackTimer;
    private float attackCooldown;

    private Animator animator;

	void Start ()
    {
        attackTimer = 0;
        attackCooldown = 1f;

        attacking = false;

        animator = GetComponent<Animator>();
    }
	
	void Update ()
    {
	    if(Input.GetKey("space") && !attacking)
        {
            attacking = true;
            attackTimer = attackCooldown;
        }

        if(attacking)
        {
            if(attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }else
            {
                attacking = false;
            }
        }
        animator.SetBool("Attacking", attacking);
	}
}
