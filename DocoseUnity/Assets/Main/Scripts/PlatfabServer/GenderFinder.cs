using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenderFinder : MonoBehaviour
{

    public TMP_InputField GenderText;
    

    public void isMale()
    {
        GenderText.text = "Male";
    }

    public void isFemale()
    {
        GenderText.text = "Female";
    }

    public void Prefer()
    {
        GenderText.text = "Prefer Not to Say";
    }

}
