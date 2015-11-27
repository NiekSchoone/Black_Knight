using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    public int itemValue;
    public string picker = "PickupCollider";
    public GameObject pointManager;

    void Awake()
    {
        pointManager = GameObject.Find("Point Manager");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == picker)
        {
            pointManager.GetComponent<PointManager>().Points += itemValue;
            Destroy(this.gameObject);
        }
    }
}
