using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollw : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    [SerializeField]
    public float smoothStep = 0.125f;
    public float smoothStepR = 10f;
    [SerializeField]
    public Vector3 offset;
    public int offsetRotation;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 desiredPoisition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPoisition, smoothStep);
        smoothedPosition.y = 0f;
        transform.position = smoothedPosition;
     //   transform.LookAt(target);

        float desiredRotation = target.transform.eulerAngles.y+offsetRotation;
        float smoothedRositionY =Mathf.LerpAngle(transform.eulerAngles.y, desiredRotation, smoothStepR);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, smoothedRositionY, transform.eulerAngles.z);
     //   transform.LookAt(target);


    }
}
