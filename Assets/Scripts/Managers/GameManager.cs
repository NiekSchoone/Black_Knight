using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private int _points;

    void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	void Update ()
    {
	
	}

    public void IncreasePoints ()
    {

    }

    public int Points
    {
        get
        {
            return _points;
        }
    }
}
