using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtonAction : MonoBehaviour
{


    public Slider slider;
    public float _sliderValue = 0.0F;
    public float sliderV = 0.0F;

    private Animator m_Animator;
    AnimatorStateInfo animationState;
    AnimatorClipInfo[] myAnimatorClip;
    public bool isShowDrawLine = false;

    public float animTime;

    float animSpeed;
    public bool isplaying;
    bool isLooping;


    private void Start()
    {






        sliderV = slider.GetComponent<Slider>().value;
    }
    private void Update()
    {
        //   m_Trail = GameObject.Find("Trail");
  
        _sliderValue = slider.normalizedValue;

        if (isplaying)
        {

            AnimatorStateInfo animationState = m_Animator.GetCurrentAnimatorStateInfo(0);
            AnimatorClipInfo[] myAnimatorClip = m_Animator.GetCurrentAnimatorClipInfo(0);

            animTime = m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime;

            Debug.Log(animTime);


            m_Animator.SetTrigger("Swing");
            m_Animator.SetFloat("SwingSpeed", animSpeed);
            m_Animator.Play("Swing",-1);


            //_sliderValue = animationState.normalizedTime;


            if (isLooping && m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
            {
                m_Animator.Play("Swing", -1,0f);
            }
            //if (isplaying && m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
            //{
            //    Play_Stop();
            //}

            mSlider_Value();
        }
        if (!isplaying && m_Animator != null)
        {
            m_Animator.Play("Swing", -1, _sliderValue);   //슬라이더값플레이
            //ShowHideTrail();
        }
        else
            return;

        sliderV = animationState.normalizedTime;




    }

    public void mSlider_Value()
    {
        sliderV = animationState.normalizedTime;
        return ;
    }

    public void Play_Swing()
    {
        m_Animator = GameObject.Find("GolfAvatar").GetComponent<Animator>();
        AnimatorClipInfo[] myAnimatorClip = m_Animator.GetCurrentAnimatorClipInfo(0);
        AnimatorStateInfo animationState = m_Animator.GetCurrentAnimatorStateInfo(0);

        animTime = myAnimatorClip[0].clip.length * animationState.normalizedTime;

        isplaying = true;
        animSpeed = 1f;
    }
    public void Play_Stop()
    {
        Renderer _renderer = GameObject.Find("Trail").GetComponent<MeshRenderer>();
        isplaying = false;
        animSpeed = 0f;
        _renderer.enabled = false;
    }


    public void Play_Slower(float changedValue)
    {
        
        animSpeed = animSpeed/changedValue;
    }

    public void Play_Faster(float changedValue)
    {
      
        animSpeed = animSpeed * changedValue;
    }

    public void Play_ReSet()
    {
        if (m_Animator != null)
        {

            animSpeed = 1f;
            m_Animator.Play("Swing", -1, 0);
        }


    }
    public void play_Loop()
    {
        isLooping = !isLooping;
    }

    public void GoHome()
    {
        SceneManager.LoadScene("VR_Main");

    }
    public void ShowHideTrail()
    {

        Renderer _renderer = GameObject.Find("Trail").GetComponent<MeshRenderer>();

        if (_renderer.enabled)
            _renderer.enabled = false;
        else
            _renderer.enabled = true;


    }

    public void ShowHideAxis()
    {
        Transform parentobj = GameObject.Find("Draw Line").transform;
        bool isShow = parentobj.FindChild("--Shoulder").gameObject.activeSelf;

        //    AxisLine.active = false;
        for (int i = 0; i < parentobj.transform.childCount; i++)
        {

            parentobj.transform.GetChild(i).gameObject.SetActive(!isShow);
        }

        isShowDrawLine = !isShow;

    }

    public void ShowHideDegree()
    {
        Transform parentobj = GameObject.Find("-------Degree----").transform;
        bool isShow = parentobj.FindChild("SwingDegree").gameObject.activeSelf;

        //    AxisLine.active = false;
        for (int i = 0; i < parentobj.transform.childCount; i++)
        {

            parentobj.transform.GetChild(i).gameObject.SetActive(!isShow);
        }

        isShowDrawLine = !isShow;


    }

}
