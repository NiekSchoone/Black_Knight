using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehaviour
{
    private int dropModifier;
    private int amountToDrop;

    private GameObject[] valuables;

	void Start ()
    {
        dropModifier = 1;

        valuables = Resources.LoadAll<GameObject>("Prefabs/Valuables");
	}

    public void DropPointObjects()
    {
        amountToDrop = Random.Range(1, 5) * dropModifier;

        for (int i = 0; i < amountToDrop; i++)
        {
            GameObject chosenCoin = valuables[Random.Range(0, valuables.Length)];
            GameObject newDroppedItem = Instantiate(chosenCoin, transform.position, Quaternion.identity) as GameObject;
        }
    }
}
