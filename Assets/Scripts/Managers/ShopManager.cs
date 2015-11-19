//Written by Rob Verhoef
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

    public void BuyWeaponUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.WeaponLevels && _equipmentManager.WeaponLevels < 6)
        { 
            _pointManager.Points -= 1000 * _equipmentManager.WeaponLevels;
            _equipmentManager.WeaponLevels++;
        }
        Debug.Log(_pointManager.Points);
        Debug.Log(_equipmentManager.WeaponLevels);
    }

    public void BuyTimerUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.TimerLevels && _equipmentManager.TimerLevels < 6)
        {
            _pointManager.Points -= 1000 * _equipmentManager.TimerLevels;
            _equipmentManager.TimerLevels++;
        }
        Debug.Log(_pointManager.Points);
        Debug.Log(_equipmentManager.TimerLevels);
    }

    public void BuyHealthUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.HealthLevels && _equipmentManager.HealthLevels < 6)
        {
            _pointManager.Points -= 1000 * _equipmentManager.HealthLevels;
            _equipmentManager.HealthLevels++;
        }
        Debug.Log(_pointManager.Points);
        Debug.Log(_equipmentManager.HealthLevels);
    }
}
