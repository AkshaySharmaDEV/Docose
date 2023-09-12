using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickShow : MonoBehaviour
{

    public GameObject bpmomyes;
    public GameObject bpmomno;
    public GameObject diabetiesmomyes;
    public GameObject diabetiesmomno;
    public GameObject obesitymomyes;
    public GameObject obesitymomno;
    public GameObject heartmomyes;
    public GameObject heartmomno;
    public GameObject strokemomyes;
    public GameObject strokemomno;

    public GameObject bpdadyes;
    public GameObject bpdadno;
    public GameObject diabetiesdadyes;
    public GameObject diabetiesdadno;
    public GameObject obesitydadyes;
    public GameObject obesitydadno;
    public GameObject heartdadyes;
    public GameObject heartdadno;
    public GameObject strokedadyes;
    public GameObject strokedadno;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTick()
    {
        if(ToServer.playerMotherBP == "Yes")
        {
            bpmomyes.SetActive(true);
        }
        else
        {
            bpmomno.SetActive(true);
        }

        if(ToServer.playerMotherDiabeties == "Yes")
        {
            diabetiesmomyes.SetActive(true);
        }
        else
        {
            diabetiesmomno.SetActive(true);
        }

        if(ToServer.playerMotherObesity == "Yes")
        {
            obesitymomyes.SetActive(true);
        }
        else
        {
            obesitymomno.SetActive(true);
        }

        if(ToServer.playerMotherHeart == "Yes")
        {
            heartmomyes.SetActive(true);
        }
        else
        {
            heartmomno.SetActive(true);
        }

        if(ToServer.playerMotherStroke == "Yes")
        {
           strokemomyes.SetActive(true);
        }
        else
        {
            strokemomno.SetActive(true);
        }



        if(ToServer.playerFatherBP == "Yes")
        {
            bpdadyes.SetActive(true);
        }
        else
        {
            bpdadno.SetActive(true);
        }

        if(ToServer.playerFatherDiabeties == "Yes")
        {
            diabetiesdadyes.SetActive(true);
        }
        else
        {
            diabetiesdadno.SetActive(true);
        }

        if(ToServer.playerFatherObesity == "Yes")
        {
            obesitydadyes.SetActive(true);
        }
        else
        {
            obesitydadno.SetActive(true);
        }

        if(ToServer.playerFatherHeart == "Yes")
        {
            heartdadyes.SetActive(true);
        }
        else
        {
            heartdadno.SetActive(true);
        }

        if(ToServer.playerFatherStroke == "Yes")
        {
            strokedadyes.SetActive(true);
        }
        else
        {
            strokedadno.SetActive(true);
        }



    }
}


