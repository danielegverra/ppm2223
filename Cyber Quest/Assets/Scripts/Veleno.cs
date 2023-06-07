using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Veleno : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    public GameObject trigger;
    public GameObject veleno;
    public GameObject teletrasporto;
    bool istakenVenom = false;
    bool isClose=false;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !istakenVenom){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player") && !istakenVenom) {
            pulsanteInterazione.SetActive(false);
            //pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && !istakenVenom) {
                pulsanteInterazione.SetActive(false);
                istakenVenom = true;
                veleno.SetActive(false);
                Inventario.obiettiviPass[1] = "";
                Inventario.vettoreInv[4] = 1;
                if(Inventario.obiettiviPass[0] == ""){
                    teletrasporto.SetActive(true);
                }
            }
        }
    }
}
