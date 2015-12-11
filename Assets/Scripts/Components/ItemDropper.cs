//Written by Niek Schoone
using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehaviour
{
    private int dropModifier;
    private int amountToDrop;
    private EquipmentManager _equipmentManager;

    private GameObject[] valuables;

    void Awake ()
    {
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
        dropModifier += _equipmentManager.WeaponLevels * 2;
        dropModifier += _equipmentManager.TimerLevels;
    }

	void Start ()
    {
        //Get all the point objects from the resources folder
        valuables = Resources.LoadAll<GameObject>("Prefabs/Valuables");
	}

    //Drop Pointgiving object
    public void DropPointObjects()
    {
        //Get a random amount of point objects
        amountToDrop = Random.Range(1, 1 + dropModifier);

        for (int i = 0; i < amountToDrop; i++)
        {
            //Choose a random point object form the valuables list and instantiate it
            GameObject chosenCoin = valuables[Random.Range(0, valuables.Length)];
            GameObject newDroppedItem = Instantiate(chosenCoin, new Vector2(transform.position.x, -4.25f), Quaternion.identity) as GameObject;
        }
    }
}
