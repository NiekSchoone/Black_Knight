//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour
{
    private int _points = 50000;

    void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public int Points
    {
        //Gets and sets the point value
        get
        {
            return _points;
        }
        set
        {
            _points = value;
        }
    }
}
