//Written by Niek Schoone
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PillageMeter : MonoBehaviour
{
    public Slider slider;
    public GameOver gameOver;
    public float pillageModifier;

    void Start()
    {
        slider.value = slider.value;

        pillageModifier = 5;
    }

	void Update ()
    {

        if(slider.value == 0)
        {
            gameOver.EndGame();
        }else
        {
            slider.value -= 10 * Time.deltaTime;
        }
    }

    public void AddToMeter()
    {
        slider.value += pillageModifier;
    }
}
