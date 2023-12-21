using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float groundDrag;
    [SerializeField] private float airMultiplier;
    [SerializeField] private float playerHeight;
    [SerializeField] LayerMask whatIsGround;
    private bool grounded;

    [SerializeField] private Transform orientation;

    private Rigidbody _rb;
    private Vector2 _input;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        _rb.drag = grounded ? groundDrag : 0;
        LimitVelocity();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 move = orientation.forward * _input.y + orientation.right * _input.x; 
        _rb.AddForce(move.normalized * speed * 10f * (grounded ? 1f : airMultiplier), ForceMode.Force);
    }

    private void LimitVelocity()
    {
        Vector3 flatVel = new Vector3(_rb.velocity.x, 0f, _rb.velocity.z);

        if (flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            _rb.velocity = new Vector3(limitedVel.x, _rb.velocity.y, limitedVel.z);
        }
    }
}
