using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Proyecto26;
using UnityEngine.UI;

public class ToServer : MonoBehaviour
{
    public TMP_Text nameInputField;
    public TMP_Text ageText;
    public TMP_Text heightText;
    public TMP_Text weightText;
    public TMP_Text maleText;
    public TMP_Text femaleText;

    

    

    public GameObject CharacterCanvas;
    public GameObject MainCanvas;
    public GameObject Warning;






    public TMP_Text BPMomText;
    public TMP_Text BPDadText;
    public TMP_Text DiabetiesMomText;
    public TMP_Text DiabetiesDadText;
    public TMP_Text ObesityMomText;
    public TMP_Text ObesityDadText;
    public TMP_Text HeartMomText;
    public TMP_Text HeartDadText;
    public TMP_Text StrokeMomText;
    public TMP_Text StrokeDadText;
    


    

    string gender;
    string skin;
    string hair;

    UserData user = new UserData();

    

    public static string playerName;
    public static string playerGender;
    public static string playerAge;
    public static string playerHeight;
    public static string playerWeight;
    public static string playerSkin;
    public static string playerHair;

    
    

    public static string playerMotherDiabeties;
    public static string playerMotherBP;
    public static string playerFatherDiabeties;
    public static string playerFatherBP;


    public static string playerMotherObesity;
    public static string playerMotherHeart;
    public static string playerFatherObesity;
    public static string playerFatherHeart;
    public static string playerMotherStroke;
    public static string playerFatherStroke;

    


    


    


    public void isMale()
    {
        gender = maleText.text;
        playerName = nameInputField.text;
        playerGender = gender;
        playerAge = ageText.text;
        playerHeight = heightText.text;
        playerWeight = weightText.text;
        playerSkin = skin;
        playerHair = hair;
        
        playerMotherDiabeties = DiabetiesMomText.text;
        playerMotherBP =  BPMomText.text;
        playerFatherDiabeties = DiabetiesDadText.text;
        playerFatherBP = BPDadText.text;
        playerMotherObesity = ObesityMomText.text;
        playerMotherHeart = HeartMomText.text;
        playerFatherObesity = ObesityDadText.text;
        playerFatherHeart = HeartDadText.text;
        playerMotherStroke = StrokeMomText.text;
        playerFatherStroke = StrokeDadText.text;

        PostToDatabase();
}
    public void isFemale()
    {
        gender = femaleText.text;
        playerName = nameInputField.text;
        playerGender = gender;
        playerAge = ageText.text;
        playerHeight = heightText.text;
        playerWeight = weightText.text;
        playerSkin = skin;
        playerHair = hair;
        
        playerMotherDiabeties = DiabetiesMomText.text;
        playerMotherBP =  BPMomText.text;
        playerFatherDiabeties = DiabetiesDadText.text;
        playerFatherBP = BPDadText.text;
        playerMotherObesity = ObesityMomText.text;
        playerMotherHeart = HeartMomText.text;
        playerFatherObesity = ObesityDadText.text;
        playerFatherHeart = HeartDadText.text;
        playerMotherStroke = StrokeMomText.text;
        playerFatherStroke = StrokeDadText.text;

        PostToDatabase();
    }

    public void skinToffee()
    {
        skin = "Toffee";
    }

    public void skinGolden()
    {
        skin = "Golden";
    }

    public void skinAlmond()
    {
        skin = "Almond";
    }

    public void skinBeige()
    {
        skin = "Beige";
    }

    public void skinVanllia()
    {
        skin = "Vanllia";
    }

    public void hairBlack()
    {
        hair = "Black";
    }

    public void hairBrown()
    {
        hair = "Brown";
    }

    public void hairAuburn()
    {
        hair = "Auburn";
    }

    public void hairGoldenBlonde()
    {
        hair = "GoldenBlonde";
    }

    public void hairBlonde()
    {
        hair = "Blonde";
    }


    public void SaveToJson()
    {
        

        

        IEnumerator LateCall()
        {
    
            yield return new WaitForSeconds(2);
    
            Warning.SetActive(false);
            
        }

        if( string.IsNullOrEmpty( ageText.text ))
        {
            
            Warning.SetActive(true);
            StartCoroutine(LateCall());
        }
        else{
            playerName = nameInputField.text;
            playerGender = gender;
            playerAge = ageText.text;
            playerHeight = heightText.text;
            playerWeight = weightText.text;
            playerSkin = skin;
            playerHair = hair;
            
            playerMotherDiabeties = DiabetiesMomText.text;
            playerMotherBP =  BPMomText.text;
            playerFatherDiabeties = DiabetiesDadText.text;
            playerFatherBP = BPDadText.text;
            playerMotherObesity = ObesityMomText.text;
            playerMotherHeart = HeartMomText.text;
            playerFatherObesity = ObesityDadText.text;
            playerFatherHeart = HeartDadText.text;
            playerMotherStroke = StrokeMomText.text;
            playerFatherStroke = StrokeDadText.text;

            
    
            

            PostToDatabase();

            CharacterCanvas.SetActive(true);
            MainCanvas.SetActive(false);
        }

        



    }



    // public void FormPush()
    // {

    //     // playerBloodSugar = sugarInputField.text;
    //     // playerBloodPressure = pressureInputField.text;

    //     BPMomText.text = playerMotherBP;
    //     BPDadText.text = playerFatherBP;
    //     DiabetiesMomText.text = playerMotherDiabeties;
    //     DiabetiesDadText.text = playerFatherDiabeties;
    //     ObesityMomText.text = playerMotherObesity;
    //     ObesityDadText.text = playerFatherObesity;
    //     HeartMomText.text = playerMotherHeart;
    //     HeartDadText.text = playerFatherHeart;
    //     StrokeMomText.text = playerMotherStroke;
    //     StrokeDadText.text = playerFatherStroke;

        
    //     PostToDatabase();

    // }

    public void FamilyHeathPush()
    {

        

        // playerMotherDiabeties = motherDiabetiesText.text;
        // playerMotherBP = motherBPText.text;
        // playerFatherDiabeties = fatherDiabetiesText.text;
        // playerFatherBP = fatherBPText.text;
        // playerGrandMotherDiabeties = grandmotherDiabetiesText.text;
        // playerGrandMotherBP = grandmotherBPText.text;
        // playerGrandFatherDiabeties = grandfatherDiabetiesText.text;
        // playerGrandFatherDP = grandfatherBPText.text;

        PostToDatabase();

        

    }

    public void ActivityPush()
    {
        // playerSportsHr = sportsInputField.text;
        // playerWalkKm = walkInputField.text; 
        // playerSwimmingHr = swimmingInputField.text; 
        // playerCyclingKm = cyclingInputField.text;
        // playerFitnessHr = fitnessInputField.text;

        PostToDatabase();

    }

    

    

    



    private void UpdateData()
    {
        

        nameInputField.text = user.Name;
        gender = user.Gender;
        ageText.text = user.Age;
        heightText.text = user.Height;
        weightText.text = user.Weight;
        skin = user.Skin;
        hair = user.Hair;

    }

    private void PostToDatabase()
    {
        UserData user = new UserData();
        RestClient.Put("https://healthapp-3cd39-default-rtdb.asia-southeast1.firebasedatabase.app/"+ playerName + ".json", user);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<UserData>("https://healthapp-3cd39-default-rtdb.asia-southeast1.firebasedatabase.app/" + nameInputField + ".json").Then(response =>
            {
                user = response;
                UpdateData();
            });
    }

    


    

    

    
}
