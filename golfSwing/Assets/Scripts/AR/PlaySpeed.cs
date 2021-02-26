using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlaySpeed : MonoBehaviour
{

    private Animator mAnimator;
    public static float mSpeed;



 
    public void pSpeed1x()
    {
        mAnimator = FindObjectOfType<Animator>();
        mAnimator.speed = 1f;

        mSpeed = mAnimator.speed;

    }
    public void pSpeed2x()
    {
        mAnimator = FindObjectOfType<Animator>();
        mAnimator.speed = 2f;

        mSpeed = mAnimator.speed;

    }
    public void pSpeed4x()
    {
        mAnimator = FindObjectOfType<Animator>();
        mAnimator.speed = 4f;

        mSpeed = mAnimator.speed;
    }
    public void pSpeed8x()
    {
        mAnimator = FindObjectOfType<Animator>();
        mAnimator.speed = 8f;

        mSpeed = mAnimator.speed;
    }

 void Update()
    {
        //if (mSpeed < 1)
        //{
        //    mSpeed = 1f;
        //}
        //else
        //    return;
        //Debug.Log("지금속도는" + mSpeed);
    }

}
