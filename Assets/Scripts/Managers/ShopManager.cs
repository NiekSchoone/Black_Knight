using UnityEngine;
using System.Collections;

public class ShopManager : MonoBehaviour
{
    private PointManager _pointManager;
    private EquipmentManager _equipmentManager;

	void Awake ()
    {
        _pointManager = GameObject.Find("Point Manager").GetComponent<PointManager>();
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
        Debug.Log(_pointManager.Points);
        DontDestroyOnLoad(transform.gameObject);
    }

    public void BuyWeapon1 ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 30)
        { 
            _pointManager.Points -= 30;
            _equipmentManager.WeaponLevels = 1;
        }
        Debug.Log(_pointManager.Points);
        Debug.Log(_equipmentManager.WeaponLevels);
    }
}
