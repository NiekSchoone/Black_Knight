using UnityEngine;
using System.Collections;

public class HitEvent : MonoBehaviour
{
    private ItemDropper drops;
    public PillageMeter meter;

    private bool isPlayer;

    void Start()
    {
        if(this.gameObject.tag == "Player")
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
        if(isPlayer == false)
        {
            Destroy(this.gameObject);
            drops.DropPointObjects();
            meter.AddToMeter();
        }else
        {

        }
    }
}
