using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextCalcuAngle_2 : MonoBehaviour
{
    //[SerializeField]
    //private Transform m_origin;
    [SerializeField]
    private Transform m_target;


    [SerializeField]
    private TextMeshProUGUI TextDeg;

    private void Update()
    {

        //  eulerAngX = transform.localEulerAngles.x;
        //       float angle = m_target.transform.eulerAngles.z;

        float angle = m_target.transform.localEulerAngles.z;
        if (angle > 180)
        { angle=  angle - 360; }

        //WrapAngle(angle);
        //     UnwrapAngle(angle);
        TextDeg.text = $"{(int)angle}'";

    }

    private static float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
            return angle - 360;

        return angle;
    }

    private static float UnwrapAngle(float angle)
    {
        if (angle >= 0)
            return angle;

        angle = -angle % 360;

        return 360 - angle;
    }
}
