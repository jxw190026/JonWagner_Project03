using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    AnimatorManager _animaiton;

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;
    //move amount is for animation transitions
    private float _moveAmount;
    public float verticalInput;
    public float horizontalInput;

    private void Awake()
    {
        _animaiton = GetComponent<AnimatorManager>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            //add vector2 values to inputs
            playerControls.PlayerMovenemt.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovenemt.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }
    
    private void HandleMovementInput()
    {
        //give vertical input the value of the y axis on movement input
        verticalInput = movementInput.y;
        //give horizontal input the value of the x axis on movement input
        horizontalInput = movementInput.x;

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;

        //call animator manager
        //abs makes all numbers positive. clamp 01 keeps the value between 0-1
        // if the horizontal or vertical value is negative change it to a positive becuase the animator works between 0-1
        _moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        _animaiton.UpdateAnimator(0, _moveAmount);


    }    



}
