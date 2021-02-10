using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonAction : MonoBehaviour
{


    public Slider slider;
    public float _sliderValue = 0.0F;
    public float sliderV = 0.0F;

    private Animator m_Animator;
    AnimatorStateInfo animationState;
    AnimatorClipInfo[] myAnimatorClip;


    float animSpeed;
    bool isplaying;
    bool isLooping;


    private void Start()
    {





        sliderV = slider.GetComponent<Slider>().value;
    }
    private void Update()
    {
        //   m_Trail = GameObject.Find("Trail");


        float V = Mathf.Clamp(animationState.normalizedTime, 0, 1);
        _sliderValue = slider.normalizedValue;

        if (isplaying)
        {



            m_Animator.SetTrigger("Swing");
            m_Animator.SetFloat("SwingSpeed", animSpeed);
            m_Animator.Play("Swing", -1);


            //_sliderValue = animationState.normalizedTime;


            if (isLooping && animationState.normalizedTime > 1)
            {
                m_Animator.Play("Swing", -1, 0);
            }

            mSlider_Value(V);
        }
        if (!isplaying && m_Animator != null)
            m_Animator.Play("Swing", -1, _sliderValue);   //슬라이더값플레이
        else
            return;

        sliderV = animationState.normalizedTime;




    }

    public void mSlider_Value(float V)
    {
        sliderV = V;

    }

    public void Play_Swing()
    {
        m_Animator = GameObject.Find("GolfAvatar").GetComponent<Animator>();
        AnimatorClipInfo[] myAnimatorClip = m_Animator.GetCurrentAnimatorClipInfo(0);
        AnimatorStateInfo animationState = m_Animator.GetCurrentAnimatorStateInfo(0);


        isplaying = !isplaying;
        animSpeed = 1f;
    }
    public void Play_Stop(float changedValue)
    {

        animSpeed = 0f;
    }


    public void Play_Slower(float changedValue)
    {
        changedValue = 0.5f;
        animSpeed -= changedValue;
    }

    public void Play_Faster(float changedValue)
    {
        changedValue = 0.5f;
        animSpeed += changedValue;
    }

    public void Play_ReSet()
    {
        animSpeed = 1f;
        m_Animator.Play("Swing", -1, 0);


    }
    public void play_Loop()
    {
        isLooping = !isLooping;
    }


    public void Trail_ShowHide()
    {
        GameObject m_Trail = GameObject.Find("Trail");
        Renderer _renderer = m_Trail.GetComponent<MeshRenderer>();

        if (_renderer.enabled)
            _renderer.enabled = false;
        else
            _renderer.enabled = true;

    }

    public void ShowHideAxis()
    {
        GameObject AxisLine = GameObject.Find("Draw Line");
        //    AxisLine.active = false;
        
    }


}
