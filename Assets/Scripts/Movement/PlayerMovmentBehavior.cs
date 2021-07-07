using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentBehavior : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;
    [SerializeField]
    private float _jumpForce = 2f;

    [SerializeField]
    private CharacterController _controller;

    [SerializeField]
    private Vector3 _velocity;

    [SerializeField]
    private float _gravity = -20f;

    [SerializeField]
    private bool _onGround;
    [SerializeField]
    private Transform _groundCheck;
    [SerializeField]
    private float _groundCheckRadius = 0.4f;
    [SerializeField]
    private LayerMask groundMask;

    private void Start()
    {

    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _onGround = Physics.CheckSphere(_groundCheck.position, _groundCheckRadius, groundMask);

        if (_onGround == true && _velocity.y < 0)
        {
            _velocity.y = _gravity;
        }

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xInput + transform.forward * zInput;

        _controller.Move(move* _movementSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && _onGround == true)
        {
            _velocity.y = Mathf.Sqrt(_jumpForce * -2f * _gravity);
        }

        _velocity.y += _gravity * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);
    }
}