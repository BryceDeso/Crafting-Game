using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSpawnerBehavior : MonoBehaviour
{
    [Tooltip("Reference to the object that you want to spawn")]
    public GameObject waypoint;

    [SerializeField]
    private GroundEnemyAIBehavior enemy;

    [SerializeField]
    private float _maxTime;
    //Used to tell how much time is left until the next spawn.
    public float _timeLeft;

    private void Start()
    {

        _timeLeft = _maxTime;
        Instantiate(waypoint, transform.position, transform.rotation);
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

            Instantiate(waypoint, transform.position, transform.rotation);
        }
    }
}