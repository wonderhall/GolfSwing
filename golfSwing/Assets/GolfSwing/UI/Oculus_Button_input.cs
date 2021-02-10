using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oculus_Button_input : MonoBehaviour
{
    public Transform touchL;


    public bool controllerMoving;
 

    public bool inputA;
    public bool inputB;
    public bool inputx;
    public bool inputy;

    void Update()
    {
        touchL.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        touchL.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        
        //눌렀을때만 참//
  //      inputA = OVRInput.Get(OVRInput.RawButton.A);
   
        
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            inputA = !inputA;
        
        Debug.Log("get A button");
            

        }

        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            inputx = !inputx;
            Debug.Log("get X button");

        }

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {

            inputy = !inputy;
            Debug.Log("get Y button");
        }


        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            Application.Quit();
            inputB = !inputB;
            Debug.Log("get B button");
        }




    }





}
