using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public List<Material> effects = new List<Material>();
    public List<Renderer> characterMs = new List<Renderer>();
    [SerializeField] GameObject character;


    public void Laser() {
        character.GetComponent<Animator>().SetBool("IsAttacking", true);
        for (int i = 0; i < characterMs.Count; i++) {
            characterMs[i].material = effects[0];
        }
    }
    public void Dissolve() {
        for (int i = 0; i < characterMs.Count; i++) {
            characterMs[i].material = effects[1];
        }
    }
    public void Glitch() {
        for (int i = 0; i < characterMs.Count; i++) {
            characterMs[i].material = effects[2];
        }
    }
}
