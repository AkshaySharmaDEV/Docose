using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour
{
    public GameObject Tab1;
    public GameObject Tab2;
    public GameObject Tab3;


    public void Tab1Pressed()
    {
        Tab1.SetActive(true);
        Tab2.SetActive(false);
        Tab3.SetActive(false);
    }

    public void Tab2Pressed()
    {
        Tab1.SetActive(false);
        Tab2.SetActive(true);
        Tab3.SetActive(false);
    }

    public void Tab3Pressed()
    {
        Tab1.SetActive(false);
        Tab2.SetActive(false);
        Tab3.SetActive(true);
    }
}
