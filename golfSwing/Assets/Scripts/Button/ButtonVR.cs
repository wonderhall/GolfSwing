using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    void Update()
    {
        //touchR.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        //touchR.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        //눌렀을때만 참//
        //      inputA = OVRInput.Get(OVRInput.RawButton.A);


        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            inputA = !inputA;

            Transform parentobj = hideUI.transform;
            bool isShow = parentobj.FindChild("---UI---").gameObject.activeSelf;

            parentobj.FindChild("---UI---").gameObject.SetActive(!isShow);

   
       
       
        }


        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            //    //      Application.Quit();
            //    switch (inputB)
            //    {
            //        case true:
            //            Debug.Log("Plastic hellooo");
            //            m_UI.Play_Swing();

            //            break;
            //        case false:
            //            Debug.Log("Paper hellooo");
            //            m_UI.Play_Stop();

            //            break;
            //        default:
            //                 m_UI.Play_Swing();
            //            break;

            //    }


            //    Debug.Log("get B button");
        }




    }
}
