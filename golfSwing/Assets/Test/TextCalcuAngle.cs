using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextCalcuAngle : MonoBehaviour
{
    [SerializeField]
    private Transform m_pre;
    [SerializeField]
    private Transform m_from;
    [SerializeField]
    private Transform m_to;

    public float mWidth = 0.05f;

    [SerializeField]
    private TextMeshProUGUI TextDeg;


    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = this.GetComponent<LineRenderer>();

        lineRenderer.SetWidth(mWidth, mWidth);
    }
    void Update()
    {
        m_pre.transform.position = GameObject.Find("Bip001 R Forearm").transform.position;
        m_from.transform.position = GameObject.Find("Bip001 R Hand").transform.position;
        m_to.transform.position = GameObject.Find("Base").transform.InverseTransformPoint(GameObject.Find("Base").transform.position);

        lineRenderer.SetPosition(0, m_pre.position);
        lineRenderer.SetPosition(1, m_from.position);
        lineRenderer.SetPosition(2, m_to.position);

        //float Xo = m_origin.transform.position.x;
        //float Yo = m_origin.transform.position.y;

        //Vector2 from = new Vector2(Xo, Yo);

        //float Xt = m_target.transform.position.x;
        //float Yt = m_target.transform.position.y;

        //Vector2 to = new Vector2(Xt, Yt);


        Vector3 from = m_from.TransformPoint(transform.position);
        Vector3 to = m_to.TransformPoint(transform.position);

     //   TextDeg.text = GetAngle(from,to).ToString();
        TextDeg.text = $"{(int)GetAngle(from, to)}'";




    }





    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        float angle;
        Vector3 v = vEnd - vStart;
        angle= Mathf.Atan2((v.y), (v.x)) * Mathf.Rad2Deg;
    //    if (angle < 0f) angle += 360f;

        return angle;

    }



}
