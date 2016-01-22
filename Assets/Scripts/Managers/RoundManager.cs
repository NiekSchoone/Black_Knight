//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class RoundManager : MonoBehaviour
{
    private int _rounds;
    private int _maxRounds = 14;
    public static RoundManager Instance;

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
    }

    void OnLevelWasLoaded ()
    {
        if(_rounds >= _maxRounds)
        {
            Debug.Log("Max amount of rounds reached");
        }
    }

    public int Rounds
    {
        //Gets and sets the rounds
        get
        {
            return _rounds;
        }
        set
        {
            _rounds = value;
        }
    }
}
