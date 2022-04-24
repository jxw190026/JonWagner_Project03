using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParryMeterController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider _ParrySliderL;
    [SerializeField] Slider _ParrySliderR;
    [SerializeField] GameObject _charaterTriggerZone;

    DamageController _damage;
    PlayerBlockParry _playerParry;
    TriggerZone _TriggerZone;

    
    bool IsPlayer = true;

    public float PostureMeter = 0;
    private float PostureMeterIncrease = 1;


    float _parryCoolDown = 0f;
    float _cooldownTime = 1f;
    void Awake()
    {
       //at the start of the scene, this script will check if it is attacked to the player
       //this will change how the scripts works according to what it's attached to
        if (gameObject.CompareTag("Player"))
        {
            IsPlayer = true;
        }else
        {
            IsPlayer = false;
        }
    }

    private void Start()
    {
        if (IsPlayer == true)
        {
            _damage = GetComponent<DamageController>();
            _playerParry = GetComponent<PlayerBlockParry>();
            _TriggerZone = GetComponent<TriggerZone>();
        }


    }

    // Update is called once per frame
    void Update()
    {
        _ParrySliderR.maxValue = _ParrySliderL.maxValue;
        _ParrySliderR.value = _ParrySliderL.value;
        _ParrySliderL.value = PostureMeter;

        if (_parryCoolDown > 0)
        {
            _parryCoolDown -= Time.deltaTime;
        }
        if (_parryCoolDown < 0.1 && PostureMeter != 10)
        {
            _ParrySliderL.value -= Time.deltaTime * _cooldownTime;
        }

        PlayerParryController();



    }
    //bool _successParryLimit = (_playerParry.ParryNum > 1 && _ParrySliderL.value < 9);
    //bool test = Input.GetKey(KeyCode.F);
    private void OnTriggerEnter(Collider other)
    {
        if (IsPlayer == true)
        {
            if (other.gameObject.CompareTag("Enemy_dmg"))
            {
                //the posture meeter will not rise if the player parrys a success swing and the posture meter is > 9
                if (_playerParry.ParryNum < 2)
                {
                    PostureMeter += PostureMeterIncrease;
                    //clap so that the posture meter doesn't go beyond 10;
                    PostureMeter = Mathf.Clamp(PostureMeter, 0, 10);
                    _parryCoolDown = 10;
                    //Debug.Log($"parry cool down = {_parryCoolDown}");
                    Debug.Log($"players posture meeter is {PostureMeter}");
                }

            }
        }

    }
    private void PlayerParryController()
    {
           //Debug.Log("trigger is reconized in parry meter");

    }
}
