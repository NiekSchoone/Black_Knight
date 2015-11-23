using UnityEngine;
using System.Collections;

public class HitEvent : MonoBehaviour
{
    private ItemDropper drops;
    public PillageMeter meter;

    private bool isPlayer;
    private bool isHit;

    private Animator animator;

    void Start()
    {
        isHit = false;

        animator = GetComponent<Animator>();

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

        if(isPlayer == false)
        {
            drops.DropPointObjects();
            meter.AddToMeter();
        }else
        {

        }
    }
}
