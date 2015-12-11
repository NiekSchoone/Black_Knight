//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class HitEvent : MonoBehaviour
{
    private ItemDropper drops;
    private PillageMeter meter;
    private LifeManager life;

    private bool isPlayer;
    private bool isHit;

    [SerializeField]
    private Animator animator;
    private Collider2D myCollider;

    void Start()
    {
        isHit = false;
        myCollider = GetComponent<Collider2D>();

        if (this.gameObject.tag == "Player")
        {
            isPlayer = true;
            animator = GetComponentInChildren<Animator>();
            life = GameObject.Find("LifeManager").GetComponent<LifeManager>();
        }else
        {
            isPlayer = false;
            drops = GetComponent<ItemDropper>();
            animator = GetComponent<Animator>();
            meter = GameObject.Find("Pillage Meter").GetComponent<PillageMeter>();
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
            life.Lives--;
            Debug.Log("I've been hit!");
        }
    }
}
