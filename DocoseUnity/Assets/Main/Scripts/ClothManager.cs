using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothManager : MonoBehaviour
{
    public Material BoyClothRenderer;
    public Material GirlClothRenderer;
    public Material EyeRenderer;
    public Texture BoyCloth1, BoyCloth2, BoyCloth3, BoyCloth4, BoyCloth5;
    public Texture GirlCloth1, GirlCloth2, GirlCloth3, GirlCloth4, GirlCloth5;
    public Texture Eye1, Eye2, Eye3, Eye4, Eye5;
    

    public void Bcloth1()
    {
         BoyClothRenderer.SetTexture("_BaseMap", BoyCloth1);
    }
    public void Bcloth2()
    {
         BoyClothRenderer.SetTexture("_BaseMap", BoyCloth2);
    }
    public void Bcloth3()
    {
         BoyClothRenderer.SetTexture("_BaseMap", BoyCloth3);
    }
    public void Bcloth4()
    {
         BoyClothRenderer.SetTexture("_BaseMap", BoyCloth4);
    }
    public void Bcloth5()
    {
         BoyClothRenderer.SetTexture("_BaseMap", BoyCloth5);
    }

    public void Gcloth1()
    {
         GirlClothRenderer.SetTexture("_BaseMap", GirlCloth1);
    }
    public void Gcloth2()
    {
         GirlClothRenderer.SetTexture("_BaseMap", GirlCloth2);
    }
    public void Gcloth3()
    {
         GirlClothRenderer.SetTexture("_BaseMap", GirlCloth3);
    }
    public void Gcloth4()
    {
         GirlClothRenderer.SetTexture("_BaseMap", GirlCloth4);
    }
    public void Gcloth5()
    {
         GirlClothRenderer.SetTexture("_BaseMap", GirlCloth5);
    }

    public void eye1()
    {
         EyeRenderer.SetTexture("_BaseMap", Eye1);
    }
    public void eye2()
    {
         EyeRenderer.SetTexture("_BaseMap", Eye2);
    }
    public void eye3()
    {
         EyeRenderer.SetTexture("_BaseMap", Eye3);
    }
    public void eye4()
    {
         EyeRenderer.SetTexture("_BaseMap", Eye4);
    }
    public void eye5()
    {
         EyeRenderer.SetTexture("_BaseMap", Eye5);
    }


}
