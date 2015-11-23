using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    public int itemValue;
    public string picker = "Player";

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == picker)
        {
            Destroy(this.gameObject);
        }
    }
}
