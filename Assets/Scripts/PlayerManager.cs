using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLocalMotion playerLocalMotion;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocalMotion = GetComponent<PlayerLocalMotion>();
        cameraManager = FindObjectOfType<CameraManager>();

    }
    
    private void Update()
    {
        inputManager.HandleAllInputs();

    }

    private void FixedUpdate()
    {
        //when working with rigidboyd and movement should be in fixed update
        playerLocalMotion.HandleAllMovement();


    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }


}
