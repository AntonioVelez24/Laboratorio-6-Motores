using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody myRigidbody;

    private float movementX;
    private float movementZ;
    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        myRigidbody.velocity = new Vector3(movementX * speed, myRigidbody.velocity.y, movementZ * speed);
    }
    public void MovementX (InputAction.CallbackContext context)
    {
        movementX = context.ReadValue<float>();
    }
    public void MovementZ(InputAction.CallbackContext context)
    {
        movementZ = context.ReadValue<float>();
    }
}
