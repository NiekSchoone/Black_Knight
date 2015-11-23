using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    private float speed = -0.05f;

	void Update ()
    {
        transform.Translate(speed,0,0);

        if(this.transform.position.x < -20)
        {
            Destroy(this.gameObject);
        }
	}
}
