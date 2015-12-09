//Writtem by Rob Verhoef
using UnityEngine;
using System.Collections;

public class UniversalSpawner : MonoBehaviour
{
    private GameObject[] _objects;
    private GameObject _chosenObject;
    private int _randomSpawntime;
    [SerializeField] private int _maxSpawnTime;
    [SerializeField] private string _loadPath;
    private bool _spawning;

    void Awake()
    {
        _objects = Resources.LoadAll<GameObject>(_loadPath);
    }

    void FixedUpdate()
    {
        //Spawns an object after a randomly determined amount of time, or reduces the spawning timer
        if (_spawning == false && _randomSpawntime == 0)
        {
            Invoke("Spawn", 2.5f);
            _spawning = true;
        }
        else if (_randomSpawntime > 0)
        {
            _randomSpawntime--;
        }
    }

    void Spawn()
    {
        //A random object is chosen & spawned
        _chosenObject = _objects[Random.Range(0, _objects.Length)];
        Instantiate(_chosenObject, new Vector2 (transform.position.x, _chosenObject.transform.position.y), _chosenObject.transform.rotation);
        _randomSpawntime = Random.Range(0, _maxSpawnTime);
        _spawning = false;
    }
}
