//Written by Niek Schoone
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PillageMeter : MonoBehaviour
{
    public Slider slider;
    public GameOver gameOver;
    public float pillageModifier;
    private EquipmentManager _equipmentManager;

    void Awake()
    {
        _equipmentManager = GameObject.Find("Equipment Manager").GetComponent<EquipmentManager>();
    }

    void Start()
    {
        slider.value = slider.value;
    }

	void FixedUpdate ()
    {

        if(slider.value == 0)
        {
            gameOver.EndGame();
        }else
        {
            slider.value -= 6 / _equipmentManager.TimerLevels * Time.deltaTime;
        }
    }

    public void AddToMeter()
    {
        slider.value += 18;
    }
}
