using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcuDeg: MonoBehaviour
{
    public Transform from;
    public Transform to;
    public Transform to_localTarget;

    public TextMeshProUGUI txt;

    public float degree;
    // Start is called before the first frame update

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
