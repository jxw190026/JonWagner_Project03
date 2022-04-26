using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _mainCameraPosition;
    [SerializeField] Transform _parryCameraPosition;
    [SerializeField] Camera _mainCamera;
    [SerializeField] Camera _parryCamera;
    public bool moveCamera = false;
    bool cameraReturning = false;
    public bool CameraOrigin = true;

    float _cameraFollowTimer = 0;

    private InputAction moveCameraInput;
    private InputAction resetCamera;
    PlayerControls playerControls;
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

        }

        playerControls.Enable();
        moveCameraInput = playerControls.Debug.CameraMove;
        moveCameraInput.Enable();
        //moveCameraInput.performed += newCameraPosition;

        resetCamera = playerControls.Debug.CameraReset;
        resetCamera.Enable();
        // resetCamera.performed += ReturnCamera;
    }

    private void OnDisable()
    {
        playerControls.Disable();
        moveCameraInput.Disable();
        resetCamera.Disable();
    }

    void Update()
    {
        if (moveCamera == true)
        {
            _mainCamera.gameObject.SetActive(false);
            _parryCamera.gameObject.SetActive(true);
            _parryCamera.GetComponent<SecondaryCameraFollow>().FollowParryCamera();
        }else
        {

            _parryCamera.GetComponent<SecondaryCameraFollow>().FollowMainCamera();
        }

        if (moveCamera == false && cameraReturning == false)
        {
            _mainCamera.gameObject.SetActive(true);
            _parryCamera.gameObject.SetActive(false);
        }

        if (_cameraFollowTimer <= 0)
        {
            cameraReturning = false;
            Debug.Log("camera moving time up");
        }
        
        if (cameraReturning == true)
        {
        _cameraFollowTimer -= Time.deltaTime;
        }

    }

    public void newCameraPosition()
    {
        moveCamera = true;
        _cameraFollowTimer = 0.5f;
        cameraReturning = false;

    }

    public void ReturnCamera()
    {
        moveCamera = false;


        cameraReturning = true;
        
    }


}
