using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{
    public TMP_Text sliderValue;
    public Slider slider;

    void Update(){

         sliderValue.text = slider.value.ToString("0.0");
 
    }
}
