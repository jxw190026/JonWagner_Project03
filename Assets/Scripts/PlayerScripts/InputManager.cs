using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    AnimatorManager _animaiton;
    PlayerBlockParry _parry;
    DamageController _damage;

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;
    //move amount is for animation transitions
    private float _moveAmount;
    public float verticalInput;
    public float horizontalInput;

    public bool ParryInput;
    private bool _parryInputRelease;
    private bool _parryInput;
    private InputAction Parry;
    private InputAction _parryRelease;
    private InputAction _hitDebug;



    private void Awake()
    {
        _animaiton = GetComponent<AnimatorManager>();
        _parry = GetComponent<PlayerBlockParry>();
        _damage = GetComponent<DamageController>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            //add vector2 values to inputs
            playerControls.PlayerMovenemt.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovenemt.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
            //playerControls.Parry.Blocking.performed += i => _parryInput = i.performed;
            //playerControls.Parry.BlockingRelease.performed += i => _parryInputRelease = i.performed; 
        }

        playerControls.Enable();
        Parry = playerControls.Parry.Blocking;
        Parry.Enable();
        Parry.performed += BlockingInput;

        _parryRelease = playerControls.Parry.BlockingRelease;
        _parryRelease.Enable();
        _parryRelease.performed += BlockingRelease;

        _hitDebug = playerControls.Debug.Hit;
        _hitDebug.Enable();
        _hitDebug.performed += hitDebuging;
    }

    private void OnDisable()
    {
        playerControls.Disable();
        Parry.Disable();
        _parryRelease.Disable();
        _hitDebug.Disable();
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

    private void Update()
    {
        //BlockingInput();
    }

    private void BlockingInput(InputAction.CallbackContext context)
    {
        Debug.Log("blocking");
        ParryInput = true;
        
    }

    private void BlockingRelease(InputAction.CallbackContext context)
    {
        Debug.Log("blocking release");
        ParryInput = false;
    }    

    private void hitDebuging(InputAction.CallbackContext context)
    {
        Debug.Log("hit");
        _damage.PlayerHit = true;
    }


}
