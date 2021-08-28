using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [Tooltip("Reference to the object that you want to spawn")]
    [SerializeField]
    private GameObject _spawnRef;

    private float _maxTime;
    //Used to tell how much time is left until the next spawn.
    public float _timeLeft;

    private void Start()
    {
        _timeLeft = _maxTime;
        Instantiate(_spawnRef, transform.position, transform.rotation);
    }

    // Start is called before the first frame update
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            _timeLeft = _maxTime;
        }
    }
}