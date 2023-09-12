
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserData
{
    public string Name;
    public string Gender;
    public string Age;
    public string Height;
    public string Weight;
    public string Skin;
    public string Hair;
    
    public string MotherDiabeties;
    public string MotherBP;
    public string MotherObesity;
    public string MotherHeart;
    public string MotherStroke;


    public string FatherDiabeties;
    public string FatherBP;
    public string FatherObesity;
    public string FatherHeart;
    public string FatherStroke;
    

    
    
    

    public UserData()
    {
        Name = ToServer.playerName;
        Gender = ToServer.playerGender;
        Age = ToServer.playerAge;
        Height = ToServer.playerHeight;
        Weight = ToServer.playerWeight;
        Skin = ToServer.playerSkin;
        Hair = ToServer.playerHair;

        
        MotherDiabeties = ToServer.playerMotherDiabeties;
        MotherBP = ToServer.playerMotherBP;
        FatherDiabeties = ToServer.playerFatherDiabeties;
        FatherBP = ToServer.playerFatherBP;

        MotherObesity = ToServer.playerMotherObesity;
        MotherHeart = ToServer.playerMotherHeart;
        FatherObesity = ToServer.playerFatherObesity;
        FatherHeart = ToServer.playerFatherHeart;
        MotherStroke = ToServer.playerMotherStroke;
        FatherStroke = ToServer.playerFatherStroke;
        

        
        

    }    
}
