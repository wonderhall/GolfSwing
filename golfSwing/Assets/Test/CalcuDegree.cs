using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcuDegree : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public TextMeshProUGUI txt;

    public float degree;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        

        Vector3 f = from.transform.TransformPoint(from.position);
        Vector3 t = to.transform.TransformPoint(to.position); 
        Vector3 toTarget = (to.position - from.position).normalized;
        float Dot = Vector3.Dot(toTarget, from.right);


        float acos = Mathf.Acos(Dot);
        float angle = (acos * 180 / Mathf.PI)-90f;
       

  

        degree = vectorDegree(f,t)*Mathf.Rad2Deg;
        txt.text = $"{angle}";

        Debug.Log(angle);

    }

    float vectorDegree(Vector3 f,Vector3 t)
    {
      
        float Dot = Vector3.Dot(f, t);
        float angle = Mathf.Acos(Dot);

        return angle;
    }
}
