using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPostureSystem : MonoBehaviour
{
    [SerializeField] Slider _postureMeter;

    public float EnemyPosture = 0;
    public float enemyMaxPosture = 10;

    float PostureTimer =0;
    float PostureCoolDown = 10;

    Animator _animation;

    public bool stagger = false;
    void Awake()
    {
        _animation = GetComponent<Animator>();
        _postureMeter.maxValue = enemyMaxPosture;
    }

    // Update is called once per frame
    void Update()
    {
        _animation.SetBool("Stagger", stagger);

        enemyPostureSystem();

        _postureMeter.value = EnemyPosture;

        if (EnemyPosture > 10)
        {
            EnemyPosture = 10;
        }
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
}
