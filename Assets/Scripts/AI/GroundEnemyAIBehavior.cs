using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundEnemyAIBehavior : MonoBehaviour
{
    public float health;
    public float damage;

    [Tooltip("The rigidbody attachted to this object.")]
    [SerializeField]
    private Rigidbody _rigidbody;
    [Tooltip("The object the enemy will be seeking towards.")]
    [SerializeField]
    public GameObject target;
    private NavMeshAgent _agent;

    [SerializeField]
    private bool seePlayer = false;

    [SerializeField]
    private GameObject wanderAnchor;
    [SerializeField]
    private GameObject wanderPoint;

    [SerializeField]
    private bool canMove = true;
    [SerializeField]
    private float _TimeTillNextWander;
    [SerializeField]
    private float _timeLeft;
    private float _minTimeWandering;
    private float _maxTimeWandering;

    public GameObject Target
    {
        get
        {
            return target;
        }
        set
        {
            target = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _timeLeft = _TimeTillNextWander;
        _rigidbody = GetComponent<Rigidbody>();
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckIfDead();
        RotateWander();
        if(seePlayer == false)
        {
            Wander();
        }
    }

    private void FixedUpdate()
    {
        //If a target hasn't been set return
        if (!target)
            return;

        _agent.SetDestination(target.transform.position);
    }

    private void Wander()
    {
        if(canMove)
        {
            target = wanderPoint;
            _timeWandering = Random.Range()
        }
        if(!canMove)
        {
            target = null;
        }
        Timer();
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            canMove = true;
            _timeLeft = _TimeTillNextWander;
        }
    }

    private void RotateWander()
    {
        if(!canMove)
        {
            wanderAnchor.transform.Rotate(0, 1, 0);
        }
    }

    private void CheckIfDead()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}