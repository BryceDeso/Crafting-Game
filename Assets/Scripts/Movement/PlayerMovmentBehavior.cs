using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentBehavior : MonoBehaviour
{
    private PlayerInputBehavior _playerInput;

    //A reference to the rigidbody component
    private Rigidbody _rigidbody;

    //A varibale that handles the movement speed of the player
    public float moveSpeed;

    //A reference of a Vector3
    private Vector3 _velocity;

    public Vector3 Velocity
    {
        get
        {
            return _velocity;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GetComponent<PlayerInputBehavior>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _velocity = direction * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
