using UnityEngine;
using System.Collections;

public class ShopManager : MonoBehaviour
{
    private GameManager _gameManager;

	void Awake ()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
	
	void Update ()
    {
	
	}
}
