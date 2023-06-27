using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChiavePassword : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    public GameObject trigger;
    public GameObject chiave;
    public GameObject teletrasporto;
    bool istaken = false;
    bool isClose=false;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !istaken){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player") && !istaken) {
            pulsanteInterazione.SetActive(false);
            //pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && !istaken) {
                pulsanteInterazione.SetActive(false);
                istaken = true;
                chiave.SetActive(false);
                Inventario.obiettiviPass[0] = "";
                Inventario.vettoreInv[1] = 1;
                teletrasporto.SetActive(true);

            }
        }
    }
}
