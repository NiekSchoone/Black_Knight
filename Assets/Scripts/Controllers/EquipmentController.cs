//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class EquipmentController : MonoBehaviour
{
    private EquipmentManager _equipmentManager;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private string _loadPath;
    [SerializeField] private string _EquipmentType;
    private Object[] _sprites;

    void Awake ()
    {
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
        _sprites = Resources.LoadAll(_loadPath, typeof(Object));
    }

    void Start ()
    {
        
    }
}
