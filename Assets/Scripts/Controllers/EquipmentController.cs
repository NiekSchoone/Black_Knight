//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class EquipmentController : MonoBehaviour
{
    private EquipmentManager _equipmentManager;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private string _loadPath;
    [SerializeField] private string _EquipmentType;
    private Sprite[] _sprites;
    private Sprite _currentSprite;
    private string _currentUpgradeLevel;

    void Awake ()
    {
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
        _sprites = Resources.LoadAll<Sprite>(_loadPath);
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start ()
    {
        //Decides what kind of equipment needs to be replaced
        if (_EquipmentType == "shield" || _EquipmentType == "head" || _EquipmentType == "shoulder")
        {
            _currentUpgradeLevel = _EquipmentType + (_equipmentManager.HealthLevels.ToString());
        }
        else if (_EquipmentType == "beard")
        {
            _currentUpgradeLevel = _EquipmentType + (_equipmentManager.TimerLevels.ToString());
        }
        else if (_EquipmentType == "weapon")
        {
            _currentUpgradeLevel = _EquipmentType + (_equipmentManager.WeaponLevels.ToString());
        }
        //Replaces equipment with the needed sprite
        for (int i = 0; i < _sprites.Length; i++)
        {
            if (_sprites[i].name == _currentUpgradeLevel)
            {
               _spriteRenderer.sprite = _sprites[i];
            }
        }
    }
}
