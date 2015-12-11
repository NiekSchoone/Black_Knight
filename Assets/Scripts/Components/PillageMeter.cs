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
        slider.maxValue = slider.maxValue += _equipmentManager.TimerLevels * 10;
        slider.value = slider.maxValue;
    }

	void FixedUpdate ()
    {

        if(slider.value == 0)
        {
            gameOver.EndGame();
        }else
        {
            slider.value -= 5 * Time.deltaTime;
        }
    }

    public void AddToMeter()
    {
        slider.value += 10;
    }
}
