using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwingDegree : MonoBehaviour
{
    [SerializeField]
    private Transform m_target;  
    [SerializeField]
    private Transform m_origin;
    //[SerializeField]
    //private GameObject m_target;
    [SerializeField]
    //private GameObject m_origin;
    //[SerializeField]
    private TextMeshProUGUI TextDeg;

    //private Vector3 origin;
    //private Transform target;



    // Update is called once per frame
    void Update()
    {
        //Vector3 origen = m_target.transform.position;
        //Vector3 target = m_target.transform.position;


        ////      float angle = Mathf.Atan2(origin.y, target.x) * Mathf.Rad2Deg;
        //Vector3 direction = target - origen;

        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //if (angle < 0f) angle += 360f;
        ////////////////


        //float angle = Vector3.Angle((m_target.transform.position - m_origin.transform.position), m_origin.transform.right);
        //float angle2 = Vector3.Angle((m_target.transform.position - m_origin.transform.position), m_origin.transform.right);

        //if (angle2 > 90)
        //{
        //    angle = 360 - angle;
        //}
        //float angle = Vector3.Angle((m_target.transform.position - m_origin.transform.position), m_origin.transform.right);

        //float angle = Vector3.Angle(transform.position, m_target.position);
        //Debug.Log(angle);

        float angle = Vector3.Angle(m_origin.right, m_target.right);
        Debug.Log(angle);
        TextDeg.text = $"{(int)angle}'";

    }



}
