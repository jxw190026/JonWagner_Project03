using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject _EnemyWeapon;
    [SerializeField] GameObject _attackTriggerZone;
    [SerializeField] AudioClip[] _parrySFX;
    [SerializeField] AudioClip _staggerSFX;


    Animator _animation;
    AudioSource _audio;

    PlayerBlockParry _player;
    AnimatorManager _playerAnimaiton;
    EnemyPostureSystem _postureSystem;

    //animation bools

    //randimizer int
    int _sounds = 0;
    void Awake()
    {
        _animation = GetComponent<Animator>();
        _player = FindObjectOfType<PlayerBlockParry>();
        _playerAnimaiton = FindObjectOfType<AnimatorManager>();
        _audio = GetComponent<AudioSource>();
        _postureSystem = GetComponent<EnemyPostureSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        SuccessfulParry();
        AttackTriggerZone();



    }
    private void FixedUpdate()
    {
        _sounds = Random.Range(0, 2);
    }

    public void WeaponTagChange(string tagName)
    {
        _EnemyWeapon.transform.gameObject.tag = tagName;
    }

    private void SuccessfulParry()
    {
        _animation.SetBool("Parried", _EnemyWeapon.GetComponent<EnemyWeaponController>().parrySuccessful);
    }

    private void AttackTriggerZone()
    {
        _animation.SetBool("AttackZone", _attackTriggerZone.GetComponent<TriggerZone>().TriggerStayActivated);
    }

    public void ParryReset()
    {
        //reset the parry bool so the enemy recovers from the parry and attacks again
        _EnemyWeapon.GetComponent<EnemyWeaponController>().parrySuccessful = false;
    }

    public void PlayerParryCheck()
    {
        if (_player.ParryNum < 2)
        {
            _player.ParryNum = 2;
        }
    }

    public void parrySound()
    {
       
            _audio.clip = _parrySFX[_sounds];
            _audio.Play();

        if (_postureSystem.stagger == true)
        {
            _audio.clip = _staggerSFX;
            _audio.Play();
        }
        
    }



}
