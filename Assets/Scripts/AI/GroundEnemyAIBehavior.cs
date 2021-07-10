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
    private float _timeLeftNextWander;

    [SerializeField]
    private float _timeWandering;
    [SerializeField]
    private float _timeLeftWandering;

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
        _timeLeftNextWander = _TimeTillNextWander;
        _timeLeftWandering = _timeWandering;
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
            Timer2(false);
        }
        if(!canMove)
        {
            target = null;
            Timer(true);
        }
    }

    private void Timer(bool activeState)
    {
        _timeLeftNextWander -= Time.deltaTime;

        if (_timeLeftNextWander <= 0)
        {
            canMove = activeState;
            _timeLeftNextWander = _TimeTillNextWander;
        }
    }

    private void Timer2(bool activeState)
    {
        _timeLeftWandering -= Time.deltaTime;

        if (_timeLeftWandering <= 0)
        {
            canMove = activeState;
            _timeLeftWandering = _timeWandering;
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