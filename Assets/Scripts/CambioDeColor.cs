using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeColor : MonoBehaviour
{
    [SerializeField]private float red;
    [SerializeField]private float green;
    [SerializeField]private float blue;
    
    [SerializeField]private float max = 999;
    
    [SerializeField]private Color mainColor;
    
    [SerializeField] private ParticleSystem p;
    
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

    
    void Update()
    {
        mainColor = new Color(red*max, green*max, blue*max);
        var col = p.colorOverLifetime;
        col.enabled = true;
        col.color = mainColor;
        var col2 = p.main;
        col2.startColor = mainColor;
    }
}
