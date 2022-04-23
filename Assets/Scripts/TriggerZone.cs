using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool TriggerActivated = false;
    public string ObjectTag = null;
    private void OnTriggerEnter(Collider other)
    {
        if (ObjectTag != null)
        {
            if (other.gameObject.CompareTag(ObjectTag))
            {
                TriggerActivated = true;
            }else
            {
                TriggerActivated = false;
            }
        }
    }
}
