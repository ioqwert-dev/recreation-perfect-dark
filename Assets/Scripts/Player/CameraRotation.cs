using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float mouseSensibility;
    [SerializeField] private Transform orientation;

    private float _rotX;
    private float _rotY;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        
        Vector2 input = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Vector2 move = input * mouseSensibility;

        _rotY += move.x;

        _rotX -= move.y;
        _rotX = Mathf.Clamp(_rotX, -90f, 90f);
        
        transform.rotation = Quaternion.Euler(_rotX, _rotY, 0);
        orientation.rotation = Quaternion.Euler(0, _rotY, 0);
    }
}
