using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altare : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject chiave;
    public GameObject cerchio;

    bool isActivated = false;
    bool isClose = false;

    public string IDaltare; 
    static int numeroPortaliAttivati = 0;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !isActivated && IDaltare == "altTut" && Inventario.vettoreInv[0] == 1){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
        if (other.gameObject.CompareTag("Player") && !isActivated && IDaltare == "altPass" && Inventario.vettoreInv[1] == 1){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
        if (other.gameObject.CompareTag("Player") && !isActivated && IDaltare == "altPhis" && Inventario.vettoreInv[2] == 1){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player") && !isActivated) {
            pulsanteInterazione.SetActive(false);
            //pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && !isActivated) {
                pulsanteInterazione.SetActive(false);
                isActivated = true;
                chiave.SetActive(true);
                cerchio.SetActive(true);
                numeroPortaliAttivati++;
            }
        }
    }
}
