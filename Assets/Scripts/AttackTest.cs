using UnityEngine;
using System.Collections;

public class AttackTest : MonoBehaviour
{
    private bool attacking;

    private float attackTimer;
    private float attackCooldown;

    private Collider2D attackTrigger;

    private Animator animator;

	void Start ()
    {
        attackTimer = 0;
        attackCooldown = 1f;

        attacking = false;

        attackTrigger = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();

        attackTrigger.enabled = false;
	}
	
	void Update ()
    {
	    if(Input.GetKey("space") && !attacking)
        {
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }

        if(attacking)
        {
            if(attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }

        animator.SetBool("Attacking", attacking);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "HitObject")
        {
            Debug.Log("did i hit sth?");
            col.gameObject.GetComponent<CheckForHit>().Hit();
        }
    }
}
