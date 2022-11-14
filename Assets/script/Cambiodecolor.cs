using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiodecolor : MonoBehaviour
{
    public ParticleSystem Part;
    public ParticleSystem Part2;
    public ParticleSystem Part3;
    

    private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                var p = Part.main;
                p.startColor = new ParticleSystem.MinMaxGradient(Color.green);
                var p2 = Part2.main;
                p2.startColor = new ParticleSystem.MinMaxGradient(Color.green);
                var p3 = Part3.main;
                p3.startColor = new ParticleSystem.MinMaxGradient(Color.green);
                
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                
                var p = Part.main;
                p.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
                var p2 = Part2.main;
                p2.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
                var p3 = Part3.main;
                p3.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
                
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                var p = Part.main;
                p.startColor = new ParticleSystem.MinMaxGradient(Color.red);
                var p2 = Part2.main;
                p2.startColor = new ParticleSystem.MinMaxGradient(Color.red);
                var p3 = Part3.main;
                p3.startColor = new ParticleSystem.MinMaxGradient(Color.red);
            }
            
        }
}
