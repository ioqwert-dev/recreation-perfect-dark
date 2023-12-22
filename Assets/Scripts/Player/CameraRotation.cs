using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float mouseSensibility;
    [SerializeField] private Transform localCamera;

    private float _rotX;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Vector2 move = input * mouseSensibility;

        _rotX -= move.y;
        _rotX = Mathf.Clamp(_rotX, -90f, 90f);

        localCamera.localRotation = Quaternion.Euler(_rotX, 0f, 0f);
        transform.Rotate(Vector3.up * move.x);
    }
}
