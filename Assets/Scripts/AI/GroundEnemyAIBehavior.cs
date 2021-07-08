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
        _rigidbody = GetComponent<Rigidbody>();
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckIfDead();
    }

    private void FixedUpdate()
    {
        //If a target hasn't been set return
        if (!target)
            return;

        _agent.SetDestination(target.transform.position);
    }

    private void CheckIfDead()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}