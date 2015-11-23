using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    public int itemValue;
    public string picker = "PickupCollider";

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == picker)
        {
            Destroy(this.gameObject);
        }
    }
}
