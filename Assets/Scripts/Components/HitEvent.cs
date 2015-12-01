//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class HitEvent : MonoBehaviour
{
    private ItemDropper drops;
    private PillageMeter meter;

    private bool isPlayer;
    private bool isHit;

    private Animator animator;
    private Collider2D myCollider;

    void Start()
    {
        isHit = false;

        meter = GameObject.Find("Manager").GetComponent<PillageMeter>();
        animator = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();

        if (this.gameObject.tag == "Player")
        {
            isPlayer = true;
        }else
        {
            isPlayer = false;
            drops = GetComponent<ItemDropper>();
        }
    }

    public void Hit()
    {
        isHit = true;
        animator.SetBool("Hit", isHit);
        myCollider.enabled = false;

        if(isPlayer == false)
        {
            drops.DropPointObjects();
            meter.AddToMeter();
        }else
        {

        }
    }
}
