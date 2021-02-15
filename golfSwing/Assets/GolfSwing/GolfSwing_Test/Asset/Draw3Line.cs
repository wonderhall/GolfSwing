using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Draw3Line : MonoBehaviour
{
    private LineRenderer lineRenderer;
    [SerializeField]
    private Transform from;
    [SerializeField]
    public Transform to;

    [SerializeField]
    private TextMeshProUGUI TextDeg;

    public float mWidth = 0.05f;


    void Start()
    {
        //Pscale = GameObject.Find("golferPrefab");
        lineRenderer = this.GetComponent<LineRenderer>();
        //  lineRenderer.SetWidth(0.1f, 0);

        Transform to = GameObject.Find("Base").transform;
    }


    void Update()
    {
        Transform to = GameObject.Find("Base").transform;

     to.transform.position = new Vector3(to.position.x, to.position.y, to.position.z);

 


        //if (to.position.y > 0.75)
        //{
        //    _PositonY = 0.75f;
        //}
        //else _PositonY = to.position.y;
        //if (to.position.z < -0.5)
        //{
        //    _PositonZ = to.position.z;

        //}
        //else
        //    _PositonZ = -0.5f;
        lineRenderer.SetPosition(2, to.position);


        Vector3 _from = from.position;
        Vector3 _to = to.position;
        TextDeg.text = $"{(int)GetAngle(_from, _to)}'";
        Debug.Log("from position = " + from.position);
        Debug.Log("to position = " + to.position);
    }


    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2((v.y), (v.z)) * Mathf.Rad2Deg;
    }


}
