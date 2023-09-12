using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpotController : MonoBehaviour
{
    public GameObject spot;

    float posX;

    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     posX = spot.GetComponent<RectTransform>().position.x;

    // }

    void Update()
    {
        

    }

    public void one()
    {

        
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (-350.0f, -10.0f, 0.0f);

    }

    public void two()
    {

        
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (-175.0f, -10.0f, 0.0f);
        

    }

    public void three()
    {

        
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (0.0f, -10.0f, 0.0f);

    }

    public void four()
    {

        
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (175.0f, -10.0f, 0.0f);

    }

    public void five()
    {

        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (350.0f, -10.0f, 0.0f);

    }

    public void male()
    {
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (295.0f, -9.0f, 0.0f);
    }

    public void female()
    {
        spot.GetComponent <RectTransform> () .anchoredPosition = new Vector3 (784.0f, -9.0f, 0.0f);
    }

}   
