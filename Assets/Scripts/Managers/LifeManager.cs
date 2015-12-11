//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    private int _lives;
    private EquipmentManager _equipmentManager;

    void Awake ()
    {
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
    }

    void Start ()
    {
        _lives = _equipmentManager.HealthLevels;
    }

    public int Lives
    {
        //Gets and sets the lives value
        get
        {
            return _lives;
        }
        set
        {
            _lives = value;
        }
    }
}
