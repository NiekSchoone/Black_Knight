//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class ScenerySpawner : MonoBehaviour
{
    [SerializeField]
    private Object[] _sceneries;
    private Object _chosenScenery;
    private float _randomSpawntime;
    private bool _spawning;

    void Awake()
    {
        _sceneries = Resources.LoadAll("Prefabs/Sceneries", typeof(Object));
    }

    void Update()
    {
        //Spawns an scenery after a randomly determined amount of time, or reduces the spawning timer
        if (_spawning == false && _randomSpawntime == 0)
        {
            Invoke("Spawn", 5);
            _spawning = true;
        }
        else if (_randomSpawntime > 0)
        {
            _randomSpawntime--;
        }
    }

    void Spawn()
    {
        //A random scenery is chosen & spawned
        _chosenScenery = _sceneries[Random.Range(0, _sceneries.Length)];
        Instantiate(_chosenScenery, transform.position, transform.rotation);
        _randomSpawntime = Random.Range(15, 101);
        _spawning = false;
    }
}
