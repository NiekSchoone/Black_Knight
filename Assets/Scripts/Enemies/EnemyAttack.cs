using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    private Collider2D myCollider;

	void Start ()
    {
        myCollider = GetComponent<Collider2D>();
	}
	
	void Update ()
    {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {

        }
    }
}
