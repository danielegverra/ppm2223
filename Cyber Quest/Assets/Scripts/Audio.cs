using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    static public int audio = -1;

    /*
        0 - Apri Porta 
        1 - Portale 
        2 - Raccogli chiave 
        3 - Raccogli collezionabili 
        4 - Risposta corretta 
        5 - Risposta sbagliata 
        6 - Cartelli 
        7 - Schermi 
        8 - Morte 
        9 - Altare 
        10 - Colonna sonora
    */

    // Update is called once per frame
    void Update()
    {
        if(audio != -1) {
            GetComponents<AudioSource>()[audio].Play();
        }
        audio = -1;
    }
}
