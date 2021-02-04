using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimSliderTest1 : MonoBehaviour

{
    private Animator mAnimator;
    private Slider mySlider; //Assign the UI slider of your scene in this slot

    AnimatorClipInfo[] m_CurrentClipInfo;
    private static float mspeed;
    float m_CurrentClipLength;
    string m_ClipName;

    float animationTime;

    // Use this for initialization
    //void Start()
    //{

    //    if (GameObject.FindGameObjectWithTag("AnimSlider"))
    //    {
    //        mySlider = (Slider)FindObjectOfType(typeof(Slider));
    //    }

    //    mAnimator = FindObjectOfType<Animator>();
    //    mAnimator.speed = 0;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    mAnimator.Play("AnimSlider", -1, mySlider.normalizedValue);

    //}
    /// <summary>
    //인스턴스 없을시 문제없슴.그러나 플레이가 안됨
    /// </summary>
    /// 

    //private Animator anim;
    //public Slider slider;   //Assign the UI slider of your scene in this slot 

    //// Use this for initialization
    //void Start()
    //{
    //    anim = GetComponent<Animator>();
    //    anim.Play("Swing");
    //    anim.speed = 1;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    anim.Play("Swing", -1, slider.normalizedValue);
    //}

    //public void OnValueChanged(float changedValue)
    //{
    //    //animator.SetBool(1, true);
    //    anim.Play("Swing", -1, slider.normalizedValue);
    //}

    ////////////////////////////////////////////////





    //////////////////////////////////////////////

    public Slider slider;
    public Animator m_Animator;
  

    private AnimationClip clip;

   

    private void Start()
    {
        //      float t = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
        //  clip = GetComponent<AnimationClip>();



    //    anim.SetTrigger("Swing");
        //animator.speed = 0.0001f;
        //slider.onValueChanged.AddListener(OnValueChanged);
    }

    private void Update()
    {
        //Fetch the current Animation clip information for the base layer
        m_CurrentClipInfo = this.m_Animator.GetCurrentAnimatorClipInfo(0);
        //Access the current length of the clip
        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;
        //Access the Animation clip name
        m_ClipName = m_CurrentClipInfo[0].clip.name;




        animationTime = this.m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1; ;
        slider.value = animationTime;

        //Debug.Log("현재에니메이션은 = " + m_ClipName);
        //Debug.Log("현재에니메이션위치는 = "+ m_CurrentClipLength);
        //Debug.Log("현재슬라이더값은 = "+animationTime);
     
    }


    //public void Update()
    //{
    //    float anima   tionTime = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
    //    // in case of a looping anime, animationTime = animationTime %1f;

    //    Debug.Log("animationTime is " + slider.value);
    //    Debug.Log("animationTime is " + animationTime);

    //    // of course remove that in production

    //    slider.Set(animationTime, false);
    //}
    public void Play_Swing(float changedValue)
    {
        //vari = GameObject.Find("speed").GetComponent<mSpeed>();

  
        //   anim.speed = 0.0001f;
        //     anim.Play("Swing", -1, slider.normalizedValue);
        //   anim.Play = WrapMode.Once;
        m_Animator.SetTrigger("Swing");
        //      anim.speed = 1f;
        m_Animator.speed = 1;

     
    }

  public void m_animLength()
    {

    }


}


