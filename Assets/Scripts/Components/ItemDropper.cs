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
        dropModifier += _equipmentManager.WeaponLevels;
        dropModifier += _equipmentManager.TimerLevels / 2;
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
        amountToDrop = Random.Range(1, 6) * dropModifier;

        for (int i = 0; i < amountToDrop; i++)
        {
            //Choose a random point object form the valuables list and instantiate it
            GameObject chosenCoin = valuables[Random.Range(0, valuables.Length)];
            GameObject newDroppedItem = Instantiate(chosenCoin, this.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
