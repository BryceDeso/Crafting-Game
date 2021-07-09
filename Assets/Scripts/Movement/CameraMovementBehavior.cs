using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehavior : MonoBehaviour
{
    public Transform _player;

    [SerializeField]
    private float _mouseSensitivity = 100f;

    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        _player.Rotate(Vector3.up * mouseX);
    }
}
