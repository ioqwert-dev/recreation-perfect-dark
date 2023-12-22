using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : NetworkBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float airMultiplier;
    [SerializeField] private float groundDrag;

    [Header("Ground")]
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask whatIsGround;

    [Header("Camera")]
    [SerializeField] private GameObject localCamera;
    
    private bool _grounded;
    private Rigidbody _rb;
    private Vector2 _input;

    public override void OnStartLocalPlayer()
    {
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0, 0, 0);
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if (!isLocalPlayer) 
        {
            localCamera.SetActive(false);
            return;
        }
    }

    private void Update()
    {
        if (!isLocalPlayer) return;

        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        _grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        _rb.drag = _grounded ? groundDrag : 0;
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        LimitVelocity();
        Movement();
    }

    private void Movement()
    {
        Vector3 move = transform.forward * _input.y + transform.right * _input.x; 
        _rb.AddForce(move.normalized * speed * 10f * (_grounded ? 1f : airMultiplier), ForceMode.Force);
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
