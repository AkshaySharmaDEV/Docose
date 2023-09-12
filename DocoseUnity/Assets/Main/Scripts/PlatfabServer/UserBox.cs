using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UsersData {
    // public string name;

    public string gender;

    public string age;
    public string height;
    public string weight;

    
 
    



    


    public UsersData (string gender, string age, string height, string weight){
        
        this.gender = gender;
        this.age = age;
        this.height = height;
        this.weight = weight;

        
    }

    
}

// public class UsersGender{

//     public string gender;

//     public UsersGender(string gender)
//     {
//         this.gender = gender;
//     }
    
// }

public class UserBox : MonoBehaviour
{
    // public InputField nameInput;

    public TMP_InputField GenderText;
    public TMP_InputField ageText;
    public TMP_InputField heightText;
    public TMP_InputField weightText;

    public TMP_Text GenderText1;
    public TMP_Text ageText1;
    public TMP_Text heightText1;
    public TMP_Text weightText1;
    
    

    
    



    
    




    public UsersData ReturnClass(){
        return new UsersData(GenderText.text,ageText.text,heightText.text,weightText.text);
    }

    // public UsersGender ReturnClass1(){
    //     return new UsersGender(GenderText.text);
    // }

    // public void SetUi(UsersGender usersgender){
    //     // nameInput.text = usersdata.name;
        
    //     // WelcomeName.text = usersdata.name;
    //     // FormName.text = usersdata.name;
    //     // DashboardName.text = usersdata.name;

        

    //     GenderText.text = usersgender.gender;
        

        

    // }

    public void SetUi1(UsersData usersdata1)
    {
        GenderText.text = usersdata1.gender;

        ageText.text = usersdata1.age;
        heightText.text = usersdata1.height;
        weightText.text = usersdata1.weight;

        GenderText1.text = usersdata1.gender;

        ageText1.text = usersdata1.age;
        heightText1.text = usersdata1.height;
        weightText1.text = usersdata1.weight;

        

        
    }    


    // public void Instantiate(UsersData usersdata1)
    // {
        
    // }



    


}
