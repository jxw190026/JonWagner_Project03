using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update

    PlayerControls playerControls;

    private InputAction Reset;
    private InputAction Escape;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            //add vector2 values to inputs
            //playerControls.Parry.Blocking.performed += i => _parryInput = i.performed;
            //playerControls.Parry.BlockingRelease.performed += i => _parryInputRelease = i.performed; 
        }

        playerControls.Enable();
        Reset = playerControls.SceneReset.Reset;
        Reset.Enable();
        Reset.performed += ResetScene;

        //Parry = playerControls.Parry.Blocking;
        Escape = playerControls.SceneReset.Escape;
        Escape.Enable();
        Escape.performed += escapeGame;

    }

    private void OnDisable()
    {
        playerControls.Disable();
        Reset.Disable();
        Escape.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetScene(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void escapeGame(InputAction.CallbackContext context)
    {
        Application.Quit();
    }
}
