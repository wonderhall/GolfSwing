using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonVR : MonoBehaviour
{
    // Start is called before the first frame update
    //   public Transform touchR;


    //  public bool controllerMoving;

    public bool inputA;
    public bool inputB;

    public UIButtonAction m_UI;

    [SerializeField]
    private Transform hideUI;
    //[SerializeField]
    //private OVRInput.Controller m_controller = OVRInput.Controller.None;


    void Update()
    {



        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            inputA = !inputA;

            Transform parentobj = hideUI.transform;
            bool isShow = parentobj.Find("---UI---").gameObject.activeSelf;

            parentobj.Find("---UI---").gameObject.SetActive(!isShow);

            Debug.Log("하이드 유아이");


        }


        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Application.Quit();

        }



    }
}
