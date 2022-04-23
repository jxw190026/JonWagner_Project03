using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponController : MonoBehaviour
{

    public bool parrySuccessful = false;
    //call this public void when to change enemy weapon
    
    private void OnTriggerEnter(Collider other)
    {
        // if the sword hit box goes over the player and the parry number is greater than 1 than it is a successful parry
        //this will change parrySuccessful to true and que the enemy parried animation
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<PlayerBlockParry>().ParryNum > 1)
            {
                parrySuccessful = true;
            }
        }
    }

}
