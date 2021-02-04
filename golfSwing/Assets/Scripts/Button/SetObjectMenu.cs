using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetObjectMenu : MonoBehaviour
{
    Animator mAnimator;

    private void Start()
    {
        mAnimator = FindObjectOfType<Animator>();
    }
    public void ExitApp()
    {
        Application.Quit();
    }

    public void deleteCh()
    {


        Destroy(GameObject.Find("golferPrefab"));
    }

    /// <summary>
    /// ///////////////////////Animation----------------------------
    /// </summary>
    public void Idle()
    {
        mAnimator.SetInteger("condition", 0);
    }
    public void play_Swing()
    {
        mAnimator.SetBool("Swing", true);
        mAnimator.speed = 1f;

    }
}
