//Written by Rob Verhoef
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random; 

public class InteractableSpawner : MonoBehaviour 
{
    [SerializeField] private Object[] _interactables;
    private Object _chosenInteractable;
    private float _randomSpawntime;
    private bool _spawning;

    void Awake ()
    {
        _interactables = Resources.LoadAll("Prefabs/Interactable/Formations", typeof (Object));
    }

    void Update()
    {
        //Spawns an interactable after a randomly determined amount of time, or reduces the spawning timer
        if (_spawning == false && _randomSpawntime == 0)
        {
            Invoke("Spawn", 25);
            _spawning = true;
        }
        else if (_randomSpawntime > 0)
        {
            _randomSpawntime--;
        }
    }

    void Spawn ()
    {
        //A random interactable is chosen & spawned
        _chosenInteractable = _interactables[Random.Range(0, _interactables.Length)];
        Instantiate(_chosenInteractable, new Vector2(Random.Range(-11, 11), transform.position.y), transform.rotation);
        _randomSpawntime = Random.Range(15, 101);
        _spawning = false;
    }
}
