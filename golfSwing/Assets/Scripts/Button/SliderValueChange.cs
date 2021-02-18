using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueChange : MonoBehaviour
{
    public UIButtonAction buttonUi;

    // Start is called before the first frame update
    Slider enemySlider;

    private void Start()
    {
       Slider enemySlider = this.GetComponent<Slider>();
        
    }
    private void Update()
    {
        StartCoroutine(IncreseSlider(enemySlider));
        
    }
    public void IncreseSliderValue()
    {
        
    }

    IEnumerator IncreseSlider(Slider slider)
    {
        if (slider != null)
        {
            float timeSlice = (slider.value / 100);
            while (slider.value <= 1)
            {
                slider.value += timeSlice;
                Debug.Log(slider.value);
                yield return new WaitForSeconds(1);
                if (slider.value >= 1)
                    break;
            }
        }
        yield return null;
    }
}
