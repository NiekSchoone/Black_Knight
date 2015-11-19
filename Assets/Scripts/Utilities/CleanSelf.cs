//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class CleanSelf : MonoBehaviour
{
    private float _minScreenHeight;

	void Awake ()
    {
        _minScreenHeight = Screen.width - Screen.width * 2;
    }

	void Update ()
    {
        //Destroys the gameobject once it leaves the screen
	    if(transform.position.x < _minScreenHeight / 64)
        {
            Destroy(gameObject);
        }
	}
}
