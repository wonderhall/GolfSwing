using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimSliderTest : MonoBehaviour

{
    private Animator mAnimator;
    private Slider mySlider; //Assign the UI slider of your scene in this slot


    // Use this for initialization
    void Start()
    {

        if (GameObject.FindGameObjectWithTag("AnimSlider"))
        {
            mySlider = (Slider)FindObjectOfType(typeof(Slider));
        }

        mAnimator = FindObjectOfType<Animator>();
        //mAnimator.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        mAnimator.Play("Swing", -1, mySlider.normalizedValue);
    }



}


