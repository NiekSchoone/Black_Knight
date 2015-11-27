//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class HitEvent : MonoBehaviour
{
    private ItemDropper drops;
    public PillageMeter meter;

    private bool isPlayer;
    private bool isHit;

    private Animator animator;
    private Collider2D collider;

    void Start()
    {
        isHit = false;

        animator = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();

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
        collider.enabled = false;

        if(isPlayer == false)
        {
            drops.DropPointObjects();
            meter.AddToMeter();
        }else
        {

        }
    }
}
