//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    private int _lives;
    private EquipmentManager _equipmentManager;
    public static LifeManager Instance;

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
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
    }

    void Start ()
    {
        _lives = _equipmentManager.HealthLevels;
        Debug.Log(_lives);
    }

    public int Points
    {
        //Gets and sets the point value
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
