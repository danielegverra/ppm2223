using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Toggle bottoneFullScreen;

    public Slider audio;
    public string nomeSlider;



    void Start()
    {
        if(nomeSlider == "musica")
        {
            audio.value = Inventario.volumeMusica;
        }
        if(nomeSlider == "suoni")
        {
            audio.value = Inventario.volumeSuoni;
        }
        bottoneFullScreen.isOn = Inventario.bottoneFullScreen;   
    }
    

    public void Setvolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        if(nomeSlider == "musica")
        {
            Inventario.volumeMusica = volume;
        }
        if(nomeSlider == "suoni")
        {
            Inventario.volumeSuoni = volume;
        }
    }

    public void SetFullScreen (bool IsFullScreen)
    {
        Screen.fullScreen = IsFullScreen;
        Inventario.bottoneFullScreen = IsFullScreen;
    }

}
