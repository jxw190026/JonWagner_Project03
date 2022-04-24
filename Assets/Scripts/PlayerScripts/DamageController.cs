using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] string _damageTag = "Enemy_dmg";
    [SerializeField] BoxCollider _hitBox;

    HealthController _health;
    PlayerBlockParry _parry;
    
    public bool PlayerHit = false;

    void Awake()
    {
        _health = GetComponent<HealthController>();
        _parry = GetComponent<PlayerBlockParry>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hitReset()
    {
        PlayerHit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_damageTag))
        {
            if(other.gameObject.GetComponent<DamageAmount>())
            {
                //grabs the health float from the Healthcontroller and -= the damage from the damage item script
                if (_parry.ParryNum < 1)
                {
                    //if _parry is < than 1 then the player is blocking and recives no damage
                    _health.CurrentHealth -= other.gameObject.GetComponent<DamageAmount>()._damageAmount;
                    other.gameObject.transform.tag = "Untagged";
                }

                //player hit = true to que animation
                PlayerHit = true;


            }
        }
    }
}
