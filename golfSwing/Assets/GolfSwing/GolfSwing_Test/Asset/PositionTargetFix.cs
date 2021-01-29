using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTargetFix : MonoBehaviour
{
    public Transform mtarget;


    //    Update is called once per frame
    void Update()
    {
        transform.position = mtarget.position;
    }
}
