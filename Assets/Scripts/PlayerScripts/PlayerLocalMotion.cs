using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocalMotion : MonoBehaviour
{
    InputManager inputManager;



    Vector3 moveDirection;
    Transform cameraObject;

    Rigidbody _rigid;

    public float movementSpeed = 7;
    public float rotationSpeed = 15;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        _rigid = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }
    
    public void HandleAllMovement()
    {
        HandleMovement();
        HandleRotation();
    }
    
    private void HandleMovement()
    {
        //move foward in the direction the camera is facing
        moveDirection = cameraObject.forward * inputManager.verticalInput;
        // move left/right based on camera position
        moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
        //keep length to 1.0
        moveDirection.Normalize();
        //prevent player from walking into the sky. cannot freely walk on y axis
        moveDirection.y = 0;

        moveDirection *= movementSpeed;

        Vector3 movementVelocity = moveDirection;
        //making player velocity on the rigidbody = to moveDirection
        _rigid.velocity = movementVelocity;

    } 
    
    private void HandleRotation()
    {
        //start with 0 on all values
        Vector3 targetDirection = Vector3.zero;

        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection += cameraObject.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero)
        {
            targetDirection = transform.forward;
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;


    }
}
