using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPostureSystem : MonoBehaviour
{
    [SerializeField] Slider _postureMeterR;
    [SerializeField] Slider _postureMeterL;
    [SerializeField] GameObject _DeathblowSprite;
    [SerializeField] GameObject _weapon;

    public float EnemyPosture = 0;
    public float enemyMaxPosture = 10;

    float PostureTimer =0;
    float PostureCoolDown = 2;


    EnemyWeaponController _weaponScript;
    Animator _animation;

    public bool stagger = false;
    void Awake()
    {
        _animation = GetComponent<Animator>();
        _postureMeterR.maxValue = enemyMaxPosture;
        _weaponScript = _weapon.GetComponent<EnemyWeaponController>();
    }

    private void Start()
    {
        _postureMeterL.maxValue = _postureMeterR.maxValue;
    }

    // Update is called once per frame
    void Update()
    {

        _postureMeterL.value = _postureMeterR.value;
        _animation.SetBool("Stagger", stagger);

        enemyPostureSystem();
        DeathBlowSprite();

        _postureMeterR.value = EnemyPosture;

        if (EnemyPosture > 10)
        {
            EnemyPosture = 10;
        }

        PostureCoolDownTimer();
    }

    void enemyPostureSystem()
    {
        if (EnemyPosture >= enemyMaxPosture)
        {
            stagger = true;
            _animation.Play("EnemySTAGGER");
        }
    }

    public void resetStagger()
    {
        EnemyPosture = 0;
        stagger = false;
    }

    private void DeathBlowSprite()
    {
        if (stagger == true)
        {
            _DeathblowSprite.SetActive(true);
        }
        else
        {
            _DeathblowSprite.SetActive(false);
        }
    }

    private void PostureCoolDownTimer()
    {
       if  (_weaponScript.parrySuccessful == true && stagger == false)
        {
            PostureTimer = PostureCoolDown;
            Debug.Log("enemy posture time is " + PostureTimer);
        }

       if (PostureTimer <= 0 && EnemyPosture > 0)
        {
            EnemyPosture -= Time.deltaTime;
        }

       if (PostureTimer > 0)
        {
            PostureTimer -= Time.deltaTime;

        }
    }
}
