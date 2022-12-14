 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

 public class DissolveScript : MonoBehaviour
 {
    [Header("Dissolve")]
    [SerializeField] private AudioSource Adissolve;
     [SerializeField] private float dissolveSpeed = 1;
     [SerializeField] private float dissolveWait = 1;
     [Space] 
     [SerializeField] private bool useIndex;
     [SerializeField] private MeshRenderer dissolveMesh;
     [SerializeField] private int dissolveMeshIndex;
     
     
     [Header("References")] 
     [SerializeField]private Material dissolveMaterial;

     private bool isDissolving;

     private float dissolveValue;
     private float startValue = 1;
     private float endValue = 0;

     private int hashDissolve = Shader.PropertyToID("_DISSOLVE");

     private void Start()
     {
      if (useIndex) dissolveMaterial = dissolveMesh.materials[dissolveMeshIndex];

      dissolveMaterial.SetFloat(hashDissolve, startValue);
     }
     public void PlayButton()
     {
         StartCoroutine(MakeDissolve());
         Adissolve.Play();
     }
     
     public IEnumerator MakeDissolve()
     {
      isDissolving = true;



      dissolveValue = startValue;
      
      while (dissolveValue > endValue)
      {
       dissolveValue -= Time.deltaTime * dissolveSpeed;
       dissolveMaterial.SetFloat(hashDissolve, dissolveValue);
       yield return null;
      }
     
      dissolveValue = endValue;
      
      Debug.Log($"<color=blue><b>CHANGE!</b></color>");

      yield return new WaitForSeconds(dissolveWait);
      
      while (dissolveValue < startValue)
      {
       dissolveValue += Time.deltaTime * dissolveSpeed;
       dissolveMaterial.SetFloat(hashDissolve, dissolveValue);
       yield return null;
      }
      
      isDissolving = false;
     }
     
 }
