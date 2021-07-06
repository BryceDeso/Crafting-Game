using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentBehavior : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;

    [SerializeField]
    private CharacterController _controller;

    private Vector3 _velocity;


    private void Start()
    {

    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xInput + transform.forward * zInput;

        _controller.Move(move* _movementSpeed * Time.deltaTime);
    }
}
