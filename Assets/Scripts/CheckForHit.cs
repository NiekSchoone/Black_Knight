using UnityEngine;
using System.Collections;

public class CheckForHit : MonoBehaviour
{
    private ItemDropper drops;

    public void Hit()
    {
        Destroy(this.gameObject);
        drops = GetComponent<ItemDropper>();
        drops.DropPointObjects();
    }
}
