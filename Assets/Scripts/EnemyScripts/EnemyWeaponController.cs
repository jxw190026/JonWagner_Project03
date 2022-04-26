using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponController : MonoBehaviour
{

    [SerializeField] GameObject _EnemyGO;
    [SerializeField] GameObject _player;
    public bool parrySuccessful = false;
    //call this public void when to change enemy weapon

    //public bool that will equal the stagger bool from the enemy posture system script
    //this bool will send information to the player wether to move the camera if the enemy has been staggered
    public bool staggered = false;
    AnimatorManager _playerAnimaiton;
    private void Awake()
    {
        _playerAnimaiton = _player.GetComponent<AnimatorManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        // if the sword hit box goes over the player and the parry number is greater than 1 than it is a successful parry
        //this will change parrySuccessful to true and que the enemy parried animation
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<PlayerBlockParry>().ParryNum > 1)
            {

                _EnemyGO.GetComponent<EnemyPostureSystem>().EnemyPosture += other.gameObject.GetComponent<PlayerBlockParry>().ParryNum;
                _EnemyGO.GetComponent<EnemyController>().PlayerParryCheck();
                if (_EnemyGO.GetComponent<EnemyPostureSystem>().stagger == false)
                {
                parrySuccessful = true;
                }
                _playerAnimaiton.queParryCheck();
            }

        }
    }

    private void Update()
    {
        if (_EnemyGO.GetComponent<EnemyPostureSystem>().stagger == true)
        {
            staggered = true;
        }
        else
        {
            staggered = false;
        }
    }

}
