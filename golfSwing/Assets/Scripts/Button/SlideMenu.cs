using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMenu : MonoBehaviour
{
    public GameObject[] PanelMenu;

    //public GameObject PanelMenu2;
    //public GameObject PanelMenu3;




    public void ShowHideMenu_Speed()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu[0].GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show");
                animator.SetBool("Show", !isOpen);
                isOpen = !isOpen;
            }
        }


    }

    public void ShowHideMenu_Club()
    {

        if (PanelMenu != null)
        {
            Animator animator = PanelMenu[1].GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show");
                animator.SetBool("Show", !isOpen);

            }
        }
    }

  



    public void ShowHideMenu_Option()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu[2].GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show");
                animator.SetBool("Show", !isOpen);

            }
        }


    }

    public void Play_Swing()
    {
        Animator anim = GameObject.Find("golferPrefab").GetComponent<Animator>();
        anim.SetTrigger("Swing");
       anim.speed = 1f;

    }

    public void SpeedSlower()
    {
        Animator anim = GameObject.Find("golferPrefab").GetComponent<Animator>();
       anim.SetTrigger("Swing");

        anim.speed = 0f;

    }
}
