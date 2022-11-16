using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider2 : MonoBehaviour
{ 

    [SerializeField] private Material material2;



    public float red;
    public float green;
    public float blue;

    public float max = 999;

    public Color mainColor;

    public void UpdateRojo(float newRojo)
    {
        red = newRojo;
    }
    public void UpdateVerde(float newVerde)
    {
        green = newVerde;
    }
    public void UpdateBlue(float newBlue)
    {
        blue = newBlue;
    }

    public void Update()
    {
        material2.SetColor("_Main_Color", new Color(red*25500, green*25500, blue*25500));
        material2.SetColor("_Fresnel_Color", new Color(red*25500, green*25500, blue*25500));
    }


    /*
    public void OnEdit()
    {
        var color = bola1.colorOverLifetime;
        color.enabled = true;
        color.color = new Color(0,0,0);
    }
*/
    
    
}
