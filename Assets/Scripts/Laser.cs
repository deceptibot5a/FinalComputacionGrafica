using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    [SerializeField] private ParticleSystem bola1;
    [SerializeField] private ParticleSystem explocion;
    [SerializeField] private ParticleSystem laser;
    [SerializeField] private ParticleSystem linea1;
    [SerializeField] private ParticleSystem linea2;
    [SerializeField] private ParticleSystem linea3;


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
        
        
        
        mainColor = new Color(red*max, green*max, blue*max);
        var col = bola1.colorOverLifetime;
        col.enabled = true;
        col.color = mainColor;
        var col2 = explocion.colorOverLifetime;
        col2.enabled = true;
        col2.color = mainColor;
        var col3 = laser.colorOverLifetime;
        col3.enabled = true;
        col3.color = mainColor;
        
        var p = linea1.main;
        p.startColor = mainColor;
        var p2 = linea2.main;
        p2.startColor = mainColor;
        var p3 = linea3.main;
        p3.startColor = mainColor;
    }



    
    
}
