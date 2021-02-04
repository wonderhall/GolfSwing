using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwingDegree : MonoBehaviour
{
    //   [SerializeField]
    //   private Transform m_target;
    //   [SerializeField]
    ////   private Transform m_origin;

    //   private TextMeshProUGUI TextDeg;





    //   // Update is called once per frame
    //   void Update()
    //   {

    //       //      Vector3 direction = m_target.transform.position - m_origin.transform.position;
    //       Vector3 direction = m_target.transform.position -this.gameObject.transform.position;

    //       float angle = Mathf.Atan2(direction.y, direction.z) * Mathf.Rad2Deg;
    //       if (angle < 0f) angle += 360f;
    //       ////////////////

    //       Debug.Log(angle);
    //       TextDeg.text = $"{(int)angle}'";

    //   }

    private Transform m_target;
    
    [SerializeField]
    private Transform m_point;

    //  private Transform m_target;
    //   private Transform m_target = GameObject.FindWithTag("GolfClub_Base").transform;
    //   private Transform m_origin;

    [SerializeField]
    private TextMeshProUGUI TextDeg;

    float PositonY;
    float PositonZ;
    private void Start()
    {


        m_target = GameObject.FindWithTag("GolfClub_Base").transform;
        //      m_target = player.transform.Find("Gun").gameObject;
        //      GameObject.FindGameObjectWithTag("GolfClub_Base");
        //    m_target = FindObjectOfType<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
 
        if (m_target.position.y > 0.75)
        {
            PositonY = 0.75f;
        }
        else PositonY = m_target.position.y;
        if (m_target.position.z < -0.5)
        {
            PositonZ = m_target.position.z;

        }
        else
            PositonZ = -0.5f;



        m_point.transform.position= new Vector3(m_point.transform.position.x, PositonY, PositonZ);
        //      Vector3 direction = m_target.transform.position - m_origin.transform.position;
        Vector3 direction = m_target.transform.position - this.gameObject.transform.position;

        float angle = Mathf.Atan2(direction.y, direction.z) * Mathf.Rad2Deg;
        if (angle < 0f) angle += 360f;
        ////////////////

   
        TextDeg.text = $"{(int)angle}'";


    }
}
