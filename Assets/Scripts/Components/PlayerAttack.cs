//Written by Niek Schoone
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
        if (attackTimer <= 0)
        {
            if (!attacking)
            {
                if (Input.GetKeyDown("space"))
                {
                    attacking = true;
                    attackTimer = attackCooldown;
                }
            }
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }

        if (Input.GetKeyUp("space"))
        {
            attacking = false;
        }
        animator.SetBool("Attacking", attacking);
	}
}
