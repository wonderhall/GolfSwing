using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArmDegree : MonoBehaviour
{
 //   private GameObject m_foreArm;
    private Transform m_hand;
   private Transform m_target;

//    private Transform m_origin;
    
    
//    [SerializeField]
//    private Transform m_foreArmPoint;
    [SerializeField]
    private Transform pre;
    [SerializeField]
    private Transform from;
    [SerializeField]
    private Transform to;
   


    //   private Transform m_target = GameObject.FindWithTag("GolfClub_Base").transform;


    [SerializeField]
    private TextMeshProUGUI TextDeg;

    float PositonY;
    private void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
  //      m_foreArmPoint.transform.position = m_foreArm.transform.position;
        pre.transform.position = GameObject.Find("Bip001 R Forearm").transform.position;
        from.transform.position = GameObject.Find("Bip001 R Hand").transform.position;
        to.transform.position = GameObject.Find("Base").transform.position;

        ////////////////////////////////

   //     from.transform.position = to.TransformPoint(transform.position);
   
        Vector3 toTarget = (to.position -from.position).normalized;

        Debug.Log(toTarget);

        var dot = Vector3.Dot(toTarget, from.right);

        Debug.Log(dot);

        var acos = Mathf.Acos(dot);

        var angle = (acos * 180 / Mathf.PI);



        //Vector3 targetDir = to.position - from.transform.position;
        //targetDir.z = 0f;
        //float angle = Mathf.Atan2(targetDir.x, targetDir.y) * Mathf.Rad2Deg;
        //if (angle < 0f) angle += 360f;
        ////dir = objectB.position - objectA.position;
        ////dir.z = 0.0;
        ////angle = Mathf.Atan(dir.y, dir.x) * Mathf.Rad2Deg;



        Debug.Log("swingAngle= "+angle);
        TextDeg.text = $"{(int)angle}'";


    }
}
