using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollw : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    [SerializeField]
    public float smoothStep = 0.125f;
    [SerializeField]
    public Vector3 offset;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 desiredPoisition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPoisition, smoothStep);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
