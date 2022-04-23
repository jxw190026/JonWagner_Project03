using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLocalMotion playerLocalMotion;
    PlayerBlockParry _parry;
    DamageController _damage;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocalMotion = GetComponent<PlayerLocalMotion>();
        cameraManager = FindObjectOfType<CameraManager>();
        _parry = GetComponent<PlayerBlockParry>();
        _damage = GetComponent<DamageController>();

    }
    
    private void Update()
    {

            inputManager.HandleAllInputs();            
        


    }

    private void FixedUpdate()
    {
        if (_parry.PlayerBlocking == false && _damage.PlayerHit == false)
        { 
            //when working with rigidboyd and movement should be in fixed update
            playerLocalMotion.HandleAllMovement();        
        }



    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }


}
