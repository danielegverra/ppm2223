using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    static public int audio = -1;

    /*
        0 - Apri Porta SESSO
        1 - Portale SESSO
        2 - Raccogli chiave SESSO
        3 - Raccogli collezionabili SESSO
        4 - Risposta corretta SESSO
        5 - Risposta sbagliata SESSO
        6 - Cartelli 
        7 - Schermi SESSO
        8 - Morte SESSO
        9 - Altare SESSO
        x - Colonna sonora
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
