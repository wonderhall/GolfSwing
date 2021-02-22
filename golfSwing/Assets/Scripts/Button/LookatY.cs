using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatY : MonoBehaviour
{
    Transform lookObj;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        lookObj = this.transform;

        transform.LookAt(target);
        lookObj.transform.eulerAngles = new Vector3(0, (transform.eulerAngles.y)+180f, 0); // lock x and z axis to zero
    }
}
