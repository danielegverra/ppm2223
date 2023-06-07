using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collezionabile : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    public GameObject trigger;
    public GameObject collezionabile;
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
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && !istaken) {
                pulsanteInterazione.SetActive(false);
                istaken = true;
                collezionabile.SetActive(false);
                incrementaPunteggio();
            }
        }
    }

    void incrementaPunteggio(){
        Inventario.nPoints += 25;
    }
}
