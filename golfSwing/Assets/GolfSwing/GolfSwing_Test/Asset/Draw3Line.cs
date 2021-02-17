using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Draw3Line : MonoBehaviour
{
    private LineRenderer lineRenderer;
    //[SerializeField]
    private Transform to;

    [SerializeField]
    private TextMeshProUGUI TextDeg;

    //public float mWidth = 0.05f;
    private Vector3 tempT;

    void Start()
    {

        lineRenderer = this.GetComponent<LineRenderer>();

    //    Transform to = GameObject.Find("Base").transform;
    }


    void Update()
    {
    
        Transform to = GameObject.Find("Base").transform;
         to.position = to.TransformPoint(transform.position);//
        //float PositonY;
        //float PositonZ;
      to.position = new Vector3(Mathf.Clamp(to.position.x,-0.3f,0.3f),to.position.y,to.position.z);
        //if (to.position.y > 0.75)
        //{
        //    PositonY = 0.75f;
        //}
        //else PositonY = to.position.y;
        //if (to.position.z < -0.5)
        //{
        //    PositonZ = to.position.z;

        //}
        //else
        //    PositonZ = -0.5f;


        //to.transform.position = new Vector3(to.transform.position.x,PositonY, PositonZ);
        //to.transform.position = new Vector3(to.transform.position.x, PositonY,PositonZ);
   
        lineRenderer.SetPosition(2, to.position);


        //Vector3 _from = from.position;
        //Vector3 _to = to.position;
        //TextDeg.text = $"{(int)GetAngle(_from, _to)}'";
        //Debug.Log("from position = " + from.position);
        //Debug.Log("to position = " + to.position);
    }









}
