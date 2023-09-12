using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothToggle : MonoBehaviour
{
    public GameObject MALE;
    public GameObject FEMALE;

    public void WhenFemalePressed()
    {
        

        MALE.SetActive(false);
        FEMALE.SetActive(true);

        
                    
    }

    public void WhenMalePressed()
    {
        

        MALE.SetActive(true);
        FEMALE.SetActive(false);

        
                    
    }
    
    

    

      



    
}


