using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryCameraFollow : MonoBehaviour
{
    [SerializeField] Transform _mainCameraPosition;
    [SerializeField] Transform _parryCameraPosition;

    private Vector3 cameraFollowVelocity = Vector3.zero;
    public float followSpeed1 = 1f;
    public float followSpeed2 = 2f;


    public void FollowParryCamera()
    {
        Vector3 targetPosition = Vector3.SmoothDamp(transform.position, _parryCameraPosition.position, ref cameraFollowVelocity, followSpeed1);
        transform.position = targetPosition;

        //Quaternion targetRotation = Vector3.SmoothDamp(transform.rotation, _parryCameraPosition.rotation, ref cameraFollowVelocity, followSpeed1);
        //transform.rotation = targetRotation;

        transform.rotation = _parryCameraPosition.rotation;
    }
    public void FollowMainCamera()
    {
        Vector3 targetPosition = Vector3.SmoothDamp(transform.position, _mainCameraPosition.position, ref cameraFollowVelocity, followSpeed2);
        transform.position = targetPosition;

        transform.rotation = _mainCameraPosition.rotation;
    }
}
