using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] string _damageTag = "Enemy_dmg";
    [SerializeField] BoxCollider _hitBox;
    [SerializeField] AudioClip[] _hitSFX;
    [SerializeField] AudioClip _StaggerSFX;

    HealthController _health;
    PlayerBlockParry _parry;
    AudioSource _audio;
    AnimatorManager _animation;
    
    public bool PlayerHit = false;
    //sound randimizer
    int _sounds = 0;

    void Awake()
    {
        _health = GetComponent<HealthController>();
        _parry = GetComponent<PlayerBlockParry>();
        _audio = GetComponent<AudioSource>();
        _animation = GetComponent<AnimatorManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _sounds = Random.Range(0, 2);
    }

    private void Update()
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

    public void hitSound(int SoundNum)
    {
        if (SoundNum == 1)
        {
        _audio.clip = _hitSFX[_sounds];
            //_audio.PlayOneShot(_hitSFX[_sounds]);
            _audio.Play();
        }

        if (SoundNum == 2)
        {
            _audio.clip = _StaggerSFX;
            _audio.Play();
        }

    }
}
