//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class MeleeAttack : MonoBehaviour
{
    private Collider2D attackTrigger;

    public string thingToHit1;
    public string thingToHit2;

	void Start ()
    {
        attackTrigger = GetComponent<Collider2D>();
        attackTrigger.enabled = false;
	}
	
    public void AttackTrue()
    {
        attackTrigger.enabled = true;
    }

    public void AttackFalse()
    {
        attackTrigger.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == thingToHit1 || col.gameObject.tag == thingToHit2)
        {
            col.gameObject.GetComponent<HitEvent>().Hit();
        }
    }
}
