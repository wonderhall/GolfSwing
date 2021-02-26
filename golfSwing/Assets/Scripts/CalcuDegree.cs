using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcuDegree : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public Transform to_localTarget;

    public TextMeshProUGUI txt;

    public float degree;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    //void Update()
    //{



    //    //Vector3 f = from.transform.TransformPoint(from.position);
    //    Vector3 f = from.transform.position;
    //    Vector3 t = to.transform.position;
    //    Vector3 toTarget = (to.position - from.position).normalized;
    //    float Dot = Vector3.Dot(toTarget, from.right);


    //    float acos = Mathf.Acos(Dot);
    //    //float angle = (acos * 180 / Mathf.PI)-90f;
    //    float angle = (acos * 180 / Mathf.PI);




    //    degree = vectorDegree(f,t)*Mathf.Rad2Deg;
    //    txt.text = $"{t}";

    //    print(f);

    //}

    //float vectorDegree(Vector3 f,Vector3 t)
    //{

    //    float Dot = Vector3.Dot(f, t);
    //    float angle = Mathf.Acos(Dot);

    //    return angle;
    //}



    private void Update()
    {
        to.transform.position = to_localTarget.position;

        //Vector3 to = new Vector3(0, 1, 0);
        //Vector3 from = new Vector3(1, 0, 0);
        Vector3 t = to.transform.position;
        Vector3 f = from.transform.position;
        Vector3 targetDir = t - f;
        Vector3 forward = from.transform.forward;

    //    float angle = Vector3.Angle(f, t);


        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
   //     print(angle);
        txt.text = $"{(int)angle}'";
    }
}
