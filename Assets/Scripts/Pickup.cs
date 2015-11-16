﻿using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
