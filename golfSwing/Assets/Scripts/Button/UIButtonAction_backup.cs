using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonAction_backup : MonoBehaviour
{

    private Slider mySlider; //Assign the UI slider of your scene in this slot

    AnimatorClipInfo[] m_CurrentClipInfo;
    private static float mspeed;
    float m_CurrentClipLength;
    string m_ClipName;

    float animationTime;
    bool isplaying;

    public Slider slider;

   public Animator m_Animator;
   //public Animation anim;
   // public AnimationClip clip;

    public float _sliderValue = 0.0F;


    private void Awake()
    {
       
    }


    private void Update()
    {
        m_Animator = GameObject.Find("golferPrefab").GetComponent<Animator>();
        _sliderValue = slider.normalizedValue;
        //if (isplaying)
        //{
        //    m_Animator.SetTrigger("Swing");
        //    m_Animator.Play("Swing", -1, slider.normalizedValue);
        //    m_Animator.speed = 1f;

        //    }
        //else
        //    Debug.Log("isplaying" + isplaying);

        if (isplaying)
        {
            Debug.Log("isplaying" + isplaying);
            m_Animator.SetTrigger("Swing");

            m_Animator.speed = 1f;
            //       anim["Swing"].time = slider.value;
            //anim= GetComponent<Animation>();
   
            //Debug.Log(anim);
            if (slider.value < 0)
                _sliderValue += Time.deltaTime;

        }
        else
        {
            m_Animator.Play("Swing", -1, slider.normalizedValue);   //슬라이더값플레이
            Debug.Log("isn't playing" + isplaying);
        }
            Debug.Log(_sliderValue);


        //if (slider.value < 1)
        //{

        //    slider.value += Time.deltaTime;
        //}
        //else
        //{
        //    isplaying = false;
        //}

        //animationTime = m_Animator.GetCurrentAnimatorStateInfo(1).normalizedTime % 1; ;
        //slider.value = animationTime;


    }



    public void Play_Swing()
    {
        //m_Animator = FindObjectOfType<Animator>();
        //m_Animator.SetTrigger("Swing");
        //m_Animator.Play("Swing", -1, slider.normalizedValue);
        //m_Animator.speed = 1f;
        isplaying = true;
    }
    public void Play_Stop(float changedValue)
    {

        m_Animator = FindObjectOfType<Animator>();
  //    m_Animator.SetTrigger("Swing");
        m_Animator.speed = 0f;
        isplaying = false;
    }

    public void play_Loop()
    {

    }
}
