//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int _points;
    private Text _pointText;
    public static PointManager Instance;

    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        _pointText = GameObject.Find("Total Points Text").GetComponent<Text>();
    }

    void Update ()
    {
        //Displays the point value in the UI
        _pointText.text = ("Coins: " + Points);
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
