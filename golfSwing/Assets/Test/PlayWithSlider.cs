using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayWithSlider : MonoBehaviour
{
    private Animator anim;
    public Slider slider;   //Assign the UI slider of your scene in this slot 

    Animator m_Animator;
    string m_ClipName;
    AnimatorClipInfo[] m_CurrentClipInfo;
    float m_CurrentClipLength;
    public float timer;
    public float _sliderValue;

   public bool isPlay =false;
    // Use this for initialization
    void Start()
    {

        slider = (Slider)FindObjectOfType(typeof(Slider));

        anim = GetComponent<Animator>();

        m_Animator = gameObject.GetComponent<Animator>();

        m_CurrentClipInfo = this.m_Animator.GetCurrentAnimatorClipInfo(0);

        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;

        m_ClipName = m_CurrentClipInfo[0].clip.name;
        print(m_CurrentClipLength);
        timer = (1 / m_CurrentClipLength) / 60;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            isPlay = !isPlay;

        if (isPlay)
        {
            anim.Play("Swing", 0, slider.normalizedValue);
            slider.normalizedValue += timer;
            Debug.Log("타이머" + timer);
            Debug.Log("길이" + m_CurrentClipLength);

        }
        else
        {
            _sliderValue = slider.normalizedValue;
            anim.Play("Swing", 0, _sliderValue);
            //slider.normalizedValue = timer;

        }



    }
}
