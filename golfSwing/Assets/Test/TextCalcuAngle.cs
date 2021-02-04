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


    [SerializeField]
    private TextMeshProUGUI TextDeg;


    void Update()
    {
        m_pre = GameObject.Find("Bip001 R Forearm").transform;
        m_from = GameObject.Find("Bip001 R Hand").transform;
        m_to = GameObject.Find("Base").transform;
        //float Xo = m_origin.transform.position.x;
        //float Yo = m_origin.transform.position.y;

        //Vector2 from = new Vector2(Xo, Yo);

        //float Xt = m_target.transform.position.x;
        //float Yt = m_target.transform.position.y;

        //Vector2 to = new Vector2(Xt, Yt);


        Vector3 from = m_from.transform.position;
        Vector3 to = m_to.transform.position;

     //   TextDeg.text = GetAngle(from,to).ToString();
        TextDeg.text = $"{(int)GetAngle(from, to)}'";




    }





    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2((v.y), (v.x)) * Mathf.Rad2Deg;
    }



}
