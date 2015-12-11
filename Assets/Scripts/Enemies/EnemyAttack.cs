using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    private Collider2D myCollider;
    [SerializeField]
    private Animator animator;
    private bool attack;

    void Start ()
    {
        myCollider = GetComponent<Collider2D>();
        animator = GetComponentInParent<Animator>();
        attack = false;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            attack = true;
            animator.SetBool("Attack", attack);
        }
    }
}
