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

    public bool _noWalk = false;

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
        
        if (_parry.PlayerBlocking == true || _damage.PlayerHit == true)
        {
            _noWalk = true;

        }
        else
        {
            _noWalk = false;
        }

    }

    private void FixedUpdate()
    {
        if (_noWalk == false)
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
