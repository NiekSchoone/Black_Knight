using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour
{
	void Update ()
    {
        transform.Translate(-0.05f,0,0);

        if(this.transform.position.x < 8)
        {

        }
	}
}
