//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private int itemValue;
    [SerializeField]
    private string picker = "PickupCollider";
    [SerializeField]
    private GameObject pointManager;
    private EquipmentManager _equipmentManager;

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
