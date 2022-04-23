using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlockParry : MonoBehaviour
{
    // Start is called before the first frame update

    public float ParryNum = 0f;

    public bool PlayerBlocking = false;


    InputManager _inputs;
    DamageController _damage;

    //player inputs



    void Awake()
    {
        _inputs = GetComponent<InputManager>();
        _damage = GetComponent<DamageController>();
    }

    // Update is called once per frame
    void Update()
    {
        ParryLogic();
    }

    public void ParryEquals(int parryNumber)
    {
        if (_damage.PlayerHit == false)
        {
        ParryNum = parryNumber;
        Debug.Log("Parry meter is " + ParryNum);
        }

    }

    private void ParryLogic()
    {
        //allow releace of the right key to stop blocking
        //input manager sends a signal that the input signal is pressing the right key
        if (_inputs.ParryInput == true)
        {
            //if the right key is pressed, the the playerblock bool is true and this will senda signal to the animator controler
            PlayerBlocking = true;
        }
        else {
            //the input manager will set the parry input to falls when the right key is released and this will reset the player blocking bool
            PlayerBlocking = false;
            ParryNum = 0;
        }

        

    }
}
