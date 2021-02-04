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
    private Transform m_handPoint;
    [SerializeField]
    private Transform m_targetPoint;
   


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
        m_handPoint.transform.position = GameObject.Find("Bip001 R Hand").transform.position;
        m_targetPoint.transform.position = GameObject.Find("Base").transform.position;
        ////////////////////////////////





        //    m_target.transform.position = new Vector3(m_target.transform.position.x, m_target.transform.position.y, m_target.transform.position.z);
        //      Vector3 direction = m_target.transform.position - m_origin.transform.position;

        //Vector3 direction = m_targetPoint.transform.position - m_handPoint.transform.position;

        //float angle = Mathf.Atan2(direction.z, direction.x);


        //Vector3 targetDir = m_targetPoint.position - m_handPoint.transform.position;
        //Vector3 forward = (m_handPoint.transform.up); // In what direction blue is looking at
        //float angle = Vector3.Angle(targetDir, forward);


        Vector3 targetDir = m_targetPoint.position - m_handPoint.transform.position;
        targetDir.z = 0f;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        if (angle < 0f) angle += 360f;
        //dir = objectB.position - objectA.position;
        //dir.z = 0.0;
        //angle = Mathf.Atan(dir.y, dir.x) * Mathf.Rad2Deg;



        Debug.Log("swingAngle= "+angle);
        TextDeg.text = $"{(int)angle}'";


    }
}
