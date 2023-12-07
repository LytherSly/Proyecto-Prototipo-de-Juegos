using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Volume : MonoBehaviour
{
    public Slider SFXSlider, MusicSlider, MasterSlider;
    public AudioMixer MasterVolume, SFXVolume, MusicVolume;
    private void Update()
    {
        MasterVolume.SetFloat("Master", MasterSlider.value);
        SFXVolume.SetFloat("SFX", SFXSlider.value);
        MusicVolume.SetFloat("Music", MusicSlider.value);
    }
}
