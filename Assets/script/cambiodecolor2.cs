using UnityEngine;
using System.Collections;

public class cambiodecolor2 : MonoBehaviour {
    
    public ParticleSystem Part;
    public ParticleSystem Part2;
    public ParticleSystem Part3;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                
                var col = Part.colorOverLifetime;
                col.enabled = true;
                col.color = Color.green;
                var col2 = Part2.colorOverLifetime;
                col2.enabled = true;
                col2.color = Color.green;
                var col3 = Part3.colorOverLifetime;
                col3.enabled = true;
                col3.color = Color.green;

            }
                
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
                
            var col = Part.colorOverLifetime;
            col.enabled = true;
            col.color = Color.blue;
            var col2 = Part2.colorOverLifetime;
            col2.enabled = true;
            col2.color = Color.blue;
            var col3 = Part3.colorOverLifetime;
            col3.enabled = true;
            col3.color = Color.blue;
                
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            var col = Part.colorOverLifetime;
            col.enabled = true;
            col.color = Color.red;
            var col2 = Part2.colorOverLifetime;
            col2.enabled = true;
            col2.color = Color.red;
            var col3 = Part3.colorOverLifetime;
            col3.enabled = true;
            col3.color = Color.red;
        }
            
    }
}
