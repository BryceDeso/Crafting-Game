using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{
    public PlayerController _playerControls;

    private PlayerMovmentBehavior _playerMovement;

    private void Awake()
    {
        _playerControls = new PlayerController();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovmentBehavior>();
    }

    void FixedUpdate()
    {
        Vector2 moveDirection = _playerControls.Player.Movement.ReadValue<Vector2>();
        _playerMovement.Move(moveDirection);
    }
}
