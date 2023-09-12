using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterController : MonoBehaviour
{
    
    
    public Animator anim;

    
    public void UpdateMeter()
    {
        int count = 0;

        if(ToServer.playerMotherBP == "Yes")
        {
            count += 1;

        }
        if(ToServer.playerMotherDiabeties == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerMotherObesity == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerMotherHeart == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerMotherStroke == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerFatherBP == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerFatherDiabeties == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerFatherObesity == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerFatherHeart == "Yes")
        {
            count += 1;
        }
        if(ToServer.playerFatherStroke == "Yes")
        {
            count += 1;
        }

        Debug.Log(count);

        if(count <= 1)
        {
            
            
            anim.Play("1");
            
            

        }
        if(count <=2 && count <= 3)
        {
            
            
            anim.Play("2");
           

        }
        if(count == 4)
        {
            
            
            anim.Play("3");
            
            
        }
        if(count <=5 && count <= 6)
        {
            
            anim.Play("4");
            

        }
        if(count <=7 && count <= 8)
        {
            
            anim.Play("5");
            
            
        }
        if(count <=9)
        {
            
            anim.Play("6");
            
            
        }
        

    }

    
}
