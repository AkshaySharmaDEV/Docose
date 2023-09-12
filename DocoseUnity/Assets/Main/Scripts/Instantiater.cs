using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;


public class Instantiater : MonoBehaviour
{

    public GameObject man50;
    public GameObject man100;
    public GameObject man13;
    public GameObject woman50;
    public GameObject woman100;
    public GameObject woman13;

    


    public Material SkinMaterial;
    public Material HairMaterial;
    public Material EyeMaterial;
    public Material SkinMaterial1;
    public Material HairMaterial1;
    public Material EyeMaterial1;


    public Color SkinToffee;
    public Color SkinGolden;
    public Color SkinAlmond;
    public Color SkinBeige;
    public Color SkinVanllia;
    public Color HairBlack;
    public Color HairBrown;
    public Color HairAuburn;
    public Color HairGoldenBlonde;
    public Color HairBlonde;


    public TMP_Text PlayerNameText;
    public TMP_Text BMIText;
    public TMP_Text StatusText;
    public TMP_Text WarningText;
    public TMP_Text PronounceText;

    public TMP_Text HeightText;
    public TMP_Text WeightText;



    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {


        
 
        
    }

    public void CheckToInstantiate()
    {

        PlayerNameText.text = ToServer.playerName;


        HeightText.text = ToServer.playerHeight;
        WeightText.text = ToServer.playerWeight;

        

        float height1 = float.Parse(ToServer.playerHeight);
        float weight1 = float.Parse(ToServer.playerWeight);
        float age1 = float.Parse(ToServer.playerAge);
        

           
        

        float heightValue = ( 100 - 0 ) * (( height1 - 70 ) / ( 190 - 70 )) + 0;
        float weightValue = ( 100 - 0 ) * (( weight1 - 4 ) / ( 125 - 4 )) + 0;
        float agechildValue = ( 100 - 0 ) * (( age1 - 0 ) / ( 13 - 0 )) + 0;
        float ageadultValue = ( 100 - 0 ) * (( age1 - 14 ) / ( 50 - 14 )) + 0;
        float ageseniorValue = ( 100 - 0 ) * (( age1 - 51 ) / ( 110 - 51 )) + 0;


        

        

        Debug.Log(heightValue);
        Debug.Log(weightValue);

        

        if (ToServer.playerSkin == "Toffee")
        {
            
            SkinMaterial.color = SkinToffee;
            SkinMaterial1.color = SkinToffee;
        }
        else if (ToServer.playerSkin == "Golden")
        {
            
            SkinMaterial.color = SkinGolden;
            SkinMaterial1.color = SkinGolden;
            
        }
        else if (ToServer.playerSkin == "Almond")
        {
            
            SkinMaterial.color = SkinAlmond;
            SkinMaterial1.color = SkinAlmond;
        }
        else if (ToServer.playerSkin == "Beige")
        {
            
            SkinMaterial.color = SkinBeige;
            SkinMaterial1.color = SkinBeige;
            Debug.Log("Woring");
        }
        else 
        {
            
            SkinMaterial.color = SkinVanllia;
            SkinMaterial1.color = SkinVanllia;
        }

        if(ToServer.playerHair == "Black")
        {

            HairMaterial.color = HairBlack;
            HairMaterial1.color = HairBlack;
            EyeMaterial.color = HairBlack;
            EyeMaterial1.color = HairBlack;

        }
        else if(ToServer.playerHair == "Brown")
        {

            HairMaterial.color = HairBrown;
            HairMaterial1.color = HairBrown;
            EyeMaterial.color = HairBrown;
            EyeMaterial1.color = HairBrown;

        }
        else if(ToServer.playerHair == "Auburn")
        {

            HairMaterial.color = HairAuburn;
            HairMaterial1.color = HairAuburn;
            EyeMaterial.color = HairAuburn;
            EyeMaterial.color = HairAuburn;

        }
        else if(ToServer.playerHair == "GoldenBlonde")
        {

            HairMaterial.color = HairGoldenBlonde;
            HairMaterial1.color = HairGoldenBlonde;
            EyeMaterial.color = HairGoldenBlonde;
            EyeMaterial1.color = HairGoldenBlonde;

        }
        else if(ToServer.playerHair == "Blonde")
        {

            HairMaterial.color = HairBlonde;
            HairMaterial1.color = HairBlonde;
            EyeMaterial.color = HairBlonde;
            EyeMaterial1.color = HairBlonde;

        }


        


        
        float age = float.Parse(ToServer.playerAge);
        Debug.Log(age);

        if (age > 13 && age <= 50 && ToServer.playerGender == "MALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  man50.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (0, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (2, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (0, ageadultValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(man50, new Vector3(0, 1, 0), Quaternion.Euler(-90f,0f, 0f));


            
        }

        if (age > 50 && ToServer.playerGender == "MALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  man100.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (1, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (0, heightValue);

            skinnedMeshRenderer.SetBlendShapeWeight (0, ageseniorValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(man100, new Vector3(0, 0, 0), Quaternion.Euler(-90f,0f, 0f));

            


            
        }

        if (age < 13 && ToServer.playerGender == "FEMALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  woman13.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (1, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (0, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (0, agechildValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(woman13, new Vector3(0, 0, 0), Quaternion.Euler(-90f,0f, 0f));

            


            
        }

        if (age > 13 && age <= 50 && ToServer.playerGender == "FEMALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  woman50.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (1, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (0, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (0, ageadultValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(woman50, new Vector3(0, 0, 0), Quaternion.Euler(-90f,0f, 0f));


            
        }

        if (age > 50 && ToServer.playerGender == "FEMALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  woman100.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (1, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (0, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (0, ageseniorValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(woman100, new Vector3(0, 0, 0), Quaternion.Euler(-90f,0f, 0f));

            


            
        }

        if (age < 13 && ToServer.playerGender == "MALE")
        {



            SkinnedMeshRenderer skinnedMeshRenderer =  man13.GetComponent<SkinnedMeshRenderer> ();

            // skinnedMeshRenderer.SetBlendShapeWeight (1, weightValue);
            // skinnedMeshRenderer.SetBlendShapeWeight (0, heightValue);

            skinnedMeshRenderer.SetBlendShapeWeight (0, agechildValue);
            skinnedMeshRenderer.SetBlendShapeWeight (1, heightValue);
            skinnedMeshRenderer.SetBlendShapeWeight (2, weightValue);

            

            
            Instantiate(man13, new Vector3(0, 0, 0), Quaternion.Euler(-90f,0f, 0f));

            


            
        }

        

        float BMI;
        
        float heightsort = ((height1/100)*(height1/100));
        BMI = weight1/heightsort;
        BMI = (float)System.Math.Round(BMI, 1);

        double BMIScale;
        
        if (age > 13)
        {
            if (BMI > 24.9)
            {

                

                BMIScale = BMI - 24.9;
                BMIScale = (double)System.Math.Round(BMIScale, 1);
                
                WarningText.text = $"Lose, {BMIScale}BMI to become normal!";

                
            }

            if (BMI < 18.5)
            {
                BMIScale = 18.5 - BMI;
                BMIScale = (double)System.Math.Round(BMIScale, 1);
                
                WarningText.text = $"Gain, {BMIScale}BMI to become normal!";
            }

            if (BMI >= 18.5 && BMI <= 24.9)
            {
                WarningText.text = "You are fit & fine!";
            }
        }

        if (age < 13)
        {
            if (BMI > 24.9)
            {

                

                BMIScale = BMI - 28;
                BMIScale = (double)System.Math.Round(BMIScale, 1);
                
                WarningText.text = $"Lose, {BMIScale}BMI to become normal!";

                
            }

            if (BMI < 18.5)
            {
                BMIScale = 20 - BMI;
                BMIScale = (double)System.Math.Round(BMIScale, 1);
                
                WarningText.text = $"Gain, {BMIScale}BMI to become normal!";
            }

            if (BMI >= 20 && BMI <= 28)
            {
                WarningText.text = "You are fit & fine!";
            }
        }



        Debug.Log(BMI);

        if (age > 13)
        {
            if(BMI < 18.5 )
            {

            
                StatusText.text = "Underweight";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Underwight";
                

            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {

                
                StatusText.text = "Normal";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Normal";

            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                // $"{BMI} , You are Overweight";

                
                StatusText.text = "Overweight";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Overweight";

            }
            else if (BMI >= 30 && BMI <= 39.9)
            {

                
                StatusText.text = "Obese";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Obese";

            }
            else
            {
                
                StatusText.text = "Extreme Obesity";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are in Extreme Obesity";

            }
        }


        if (age <= 13)
        {
            if(BMI < 20)
            {

            
                StatusText.text = "Underweight";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Underweight";

            }
            else if (BMI >= 20 && BMI < 28)
            {

                
                StatusText.text = "Normal";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Normal";

            }
            else if (BMI >= 28 && BMI < 31)
            {

                
                StatusText.text = "Overweight";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Overweight";

            }
            else
            {

                
                StatusText.text = "Obese";
                BMIText.text = $"{BMI}";
                PronounceText.text = $"Hello, {ToServer.playerName} your BMI is {BMI} and you are Obese";

            }
            
        }

        

        


    }

    public void Destroy()
    {


        GameObject[] names = GameObject.FindGameObjectsWithTag("Player");
 
        foreach(GameObject item in names)
        {
            Destroy(item);
        }
        
    }
    

    


    

    
}
