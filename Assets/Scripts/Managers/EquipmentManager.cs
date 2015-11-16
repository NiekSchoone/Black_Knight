using UnityEngine;
using System.Collections;

public class EquipmentManager : MonoBehaviour
{
    private int _currentWeaponLevel;
    private int _currentTimerLevel;
    private int _currentPointMultiplierLevel;

	void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
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

    public int PointMultiplierLevels
    {
        //Gets and sets the weaponLevel
        get
        {
            return _currentPointMultiplierLevel;
        }
        set
        {
            _currentPointMultiplierLevel = value;
        }
    }
}
