//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class EquipmentManager : MonoBehaviour
{
    private int _currentWeaponLevel = 1;
    private int _currentTimerLevel = 1;
    private int _currentHealthLevel = 1;
    public static EquipmentManager Instance;

	void Awake ()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

    public int WeaponLevels
    {
        //Gets and sets the weaponLevel
        get
        {
            return _currentWeaponLevel;
        }
        set
        {
            _currentWeaponLevel = value;
        }
    }

    public int TimerLevels
    {
        //Gets and sets the timerLevel
        get
        {
            return _currentTimerLevel;
        }
        set
        {
            _currentTimerLevel = value;
        }
    }

    public int HealthLevels
    {
        //Gets and sets the weaponLevel
        get
        {
            return _currentHealthLevel;
        }
        set
        {
            _currentHealthLevel = value;
        }
    }
}
