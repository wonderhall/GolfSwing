using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIButtonAction : MonoBehaviour
{


    [SerializeField]
    private float SwingSpeed = 12.5f;
    [SerializeField]
    private OVRInput.Controller m_controller = OVRInput.Controller.None;


    //   public GameObject SpeedUI;
    public TextMeshProUGUI TextSpeed;
    public Slider slider;
    public float _sliderValue = 0.5F;
    private Animator m_Animator;


    public bool isShowDrawLine = false;





    public bool isplaying;
    public float animSpeed = 1;
    public bool isLooping;

    /// <summary>
    /// /////////////////////

    AnimatorStateInfo animationState;
    AnimatorClipInfo[] m_CurrentClipInfo;

    float m_CurrentClipLength;
    public float timer;





    /// </summary>

    private void Update()
    {

        timer = ((1 / m_CurrentClipLength) / 60 * SwingSpeed) * animSpeed;
        print("타이머" + timer);
        print("스피드" + animSpeed);


        if (isplaying)
        {
            if (isLooping && slider.normalizedValue >= 1f)
            {
                slider.normalizedValue = 0;
                m_Animator.Play("Swing", 0, slider.normalizedValue);
                slider.normalizedValue += timer;
            }
            else
            {

                m_Animator.Play("Swing", 0, slider.normalizedValue);
                slider.normalizedValue += timer;
            }


        }
        if (!isplaying && m_Animator != null)
        {
            _sliderValue = slider.normalizedValue;
            m_Animator.Play("Swing", 0, _sliderValue);   //슬라이더값플레이

        }
        if (!isplaying)
        {
    
            _sliderValue = slider.normalizedValue;
        }
  

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            isPlaying();
            Debug.Log("버튼으로 플레이");
        }

        float axis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, m_controller).x;

        if (axis != 0)
        {

            //          _sliderValue = (slider.normalizedValue)+axis;
            slider.normalizedValue += axis / 100;
            _sliderValue = slider.normalizedValue;

            m_Animator.Play("Swing", 0, _sliderValue);

         

        }
        /////

    }
    /// <summary>
    /// 여기까지 업데이트함수
    /// </summary>
    public void mSlider_Value()
    {

        return;
    }

    public void Play_Swing()
    {
        m_Animator = GameObject.Find("GolfAvatar").GetComponent<Animator>();
        m_Animator.SetTrigger("Swing");

        animationState = m_Animator.GetCurrentAnimatorStateInfo(0);
        m_CurrentClipInfo = m_Animator.GetCurrentAnimatorClipInfo(0);

        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;
        timer = ((1 / m_CurrentClipLength) / 60 * SwingSpeed);



        isplaying = true;
    }

    public void Play_Stop()
    {
        isplaying = false;

    }


    public void Play_Slower(float changedValue)
    {

        animSpeed = animSpeed / changedValue;
        animSpeed = Mathf.Clamp(animSpeed, 0.1f, 16f);
        TextSpeed.text = $"{animSpeed}x";

        animSpeed = Mathf.Round(animSpeed * 10) * 0.1f;
        StartCoroutine(ShowSpeed());
    }

    public void Play_Faster(float changedValue)
    {


        animSpeed = animSpeed * changedValue;
        animSpeed = Mathf.Clamp(animSpeed, 0.1f, 16f);
        TextSpeed.text = $"{animSpeed}x";

        StartCoroutine(ShowSpeed());

    }

    public void Play_ReSet()
    {
        if (m_Animator != null)
        {

            animSpeed = 1f;
            slider.normalizedValue = 0;

        }
        TextSpeed.text = $"{animSpeed}x";

        StartCoroutine(ShowSpeed());

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
        bool isShow = parentobj.Find("--Shoulder").gameObject.activeSelf;

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
        bool isShow = parentobj.Find("SwingDegree").gameObject.activeSelf;


        for (int i = 0; i < parentobj.transform.childCount; i++)
        {

            parentobj.transform.GetChild(i).gameObject.SetActive(!isShow);
        }

        isShowDrawLine = !isShow;


    }

    public void hideEffect()
    {

        ShowHideTrail();
        ShowHideAxis();
        ShowHideDegree();

    }

    public void GetAnim()
    {

        m_Animator = GameObject.Find("GolfAvatar").GetComponent<Animator>();
        m_Animator.SetTrigger("Swing");

        animationState = m_Animator.GetCurrentAnimatorStateInfo(0);
        m_CurrentClipInfo = m_Animator.GetCurrentAnimatorClipInfo(0);

        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;
        timer = ((1 / m_CurrentClipLength) / 60 * SwingSpeed);
        isplaying = false;




        Debug.Log("타이머" + timer);
        Debug.Log("길이" + m_CurrentClipLength);

    }



    IEnumerator ShowSpeed()
    {
        //Print the time of when the function is first called.

        Animator animator = TextSpeed.GetComponent<Animator>();
        bool isOpen = animator.GetBool("Show");
        if (TextSpeed != null)
        {
            if (animator != null)
            {
                animator.SetBool("Show", true);

            }
        }
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.3f);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("Show", false);
        print("코로틴끝");
    }

    public void isPlaying()
    {
        isplaying = !isplaying;
        Debug.Log(isplaying);
    }

    public void StickSlider()
    {
        //    _sliderValue = slider.normalizedValue;
        _sliderValue = slider.normalizedValue;

    }

    public void quit()
    {
        Application.Quit();
    }
}
