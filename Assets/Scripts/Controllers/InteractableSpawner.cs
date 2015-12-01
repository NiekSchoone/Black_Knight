//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class InteractableSpawner : MonoBehaviour
{
    [SerializeField]
    private Object[] _interactables;
    private Object _chosenInteractable;
    public int _randomSpawntime;
    private bool _spawning;

    void Awake()
    {
        _interactables = Resources.LoadAll("Prefabs/Interactables", typeof(Object));
    }

    void FixedUpdate()
    {
        //Spawns an interactable after a randomly determined amount of time, or reduces the spawning timer
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
        //A random interactable is chosen & spawned
        _chosenInteractable = _interactables[Random.Range(0, _interactables.Length)];
        Instantiate(_chosenInteractable, transform.position, transform.rotation);
        _randomSpawntime = Random.Range(0, 201);
        _spawning = false;
    }
}
