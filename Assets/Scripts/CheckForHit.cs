using UnityEngine;
using System.Collections;

public class CheckForHit : MonoBehaviour
{
    public void Hit()
    {
        Destroy(this.gameObject);
    }
}
