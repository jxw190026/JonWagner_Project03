using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool TriggerEnterActivated = false;
    public bool TriggerStayActivated = false;
    public string ObjectTag = null;
    private void OnTriggerEnter(Collider other)
    {
        if (ObjectTag != null)
        {
            if (other.gameObject.CompareTag(ObjectTag))
            {
                TriggerEnterActivated = true;
            }else
            {
                TriggerEnterActivated = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (ObjectTag != null)
        {
            if (other.gameObject.CompareTag(ObjectTag))
            {
                TriggerStayActivated = true;
            }
            else
            {
                TriggerStayActivated = false;
                Debug.Log("Trigger is not activated" + gameObject.transform.name);
            }
        }
    }
}
