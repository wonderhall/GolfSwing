using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()] // This will let you preview the animation
public class mSliderValue : MonoBehaviour
{
    public Slider slider;
    public float myValue = 0; // Animate this parameter

    void Update()
    {
        if (slider != null)
            slider.value = myValue;
    }
}

