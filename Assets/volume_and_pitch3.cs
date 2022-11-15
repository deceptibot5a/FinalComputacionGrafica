using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volume_and_pitch3 : MonoBehaviour
{
    public AudioMixer mixer;

    public void setlvlvol3 (float sliderValue)
    {
        mixer.SetFloat("Effect1vol", Mathf.Log10 (sliderValue) * 20);
    }

    public void setlvlpitch3(float sliderValue)
    {
        mixer.SetFloat("Effect2pitch", sliderValue);
    }


}
