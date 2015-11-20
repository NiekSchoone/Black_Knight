//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private PointManager _pointManager;
    private EquipmentManager _equipmentManager;
    private Text _pointText;
    private Text _weaponText;
    private Text _timerText;
    private Text _healthText;

    void Awake ()
    {
        _pointManager = GameObject.Find("Point Manager").GetComponent<PointManager>();
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
        _pointText = GameObject.Find("Total Points Text").GetComponent<Text>();
        _weaponText = GameObject.Find("Weapon Upgrade Level Text").GetComponent<Text>();
        _timerText = GameObject.Find("Beard Upgrade Level Text").GetComponent<Text>();
        _healthText = GameObject.Find("Helmet Upgrade Level Text").GetComponent<Text>();
        UpdateText();
        DontDestroyOnLoad(transform.gameObject);
    }

    public void BuyWeaponUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.WeaponLevels && _equipmentManager.WeaponLevels < 6)
        { 
            _pointManager.Points -= 1000 * _equipmentManager.WeaponLevels;
            _equipmentManager.WeaponLevels++;
            UpdateText();
        }
    }

    public void BuyTimerUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.TimerLevels && _equipmentManager.TimerLevels < 6)
        {
            _pointManager.Points -= 1000 * _equipmentManager.TimerLevels;
            _equipmentManager.TimerLevels++;
            UpdateText();
        }
    }

    public void BuyHealthUpgrade ()
    {
        //The player can buy the weapon if he has enough points, after which the required points are substracted and the weapon level is upgraded
        if (_pointManager.Points >= 1000 * _equipmentManager.HealthLevels && _equipmentManager.HealthLevels < 6)
        {
            _pointManager.Points -= 1000 * _equipmentManager.HealthLevels;
            _equipmentManager.HealthLevels++;
            UpdateText();
        }
    }

    void UpdateText ()
    {
        //Updates the UI texts
        _pointText.text = ("Coins: " + _pointManager.Points);
        if (_equipmentManager.WeaponLevels < 6)
        {
            _weaponText.text = ("Cost: " + 1000 * _equipmentManager.WeaponLevels);
        }
        else if (_equipmentManager.WeaponLevels >= 6)
        {
            _weaponText.text = ("Sold Out");
        }
        if (_equipmentManager.TimerLevels < 6)
        {
            _timerText.text = ("Cost: " + 1000 * _equipmentManager.TimerLevels);
        }
        else if (_equipmentManager.TimerLevels >= 6)
        {
            _timerText.text = ("Sold Out");
        }
        if (_equipmentManager.HealthLevels < 6)
        {
            _healthText.text = ("Cost: " + 1000 * _equipmentManager.HealthLevels);
        }
        else if (_equipmentManager.HealthLevels >= 6)
        {
            _healthText.text = ("Sold Out");
        }
    }
}
