using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class StartVolume : MonoBehaviour
{
    public AudioMixer audioMixerMusica;
    public AudioMixer audioMixerSuoni;
    void Start()
    {
        Inventario.volumeMusica = -15;
        Inventario.volumeSuoni = -15;

        audioMixerMusica.SetFloat("volume", -15);
        audioMixerSuoni.SetFloat("volume", -15);
    }
}
