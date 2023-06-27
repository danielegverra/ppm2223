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

    static int[] altariAttivi={0,0,0};

    public string IDaltare;
    public static int numeroPortaliAttivati = 0;

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
                Audio.audio = 9;
                chiave.SetActive(true);
                cerchio.SetActive(true);
                numeroPortaliAttivati++;
                if(IDaltare == "altTut"){
                    altariAttivi[0]=1;
                }else if(IDaltare == "altPass"){
                    altariAttivi[1]=1;
                }else if(IDaltare == "altPhis"){
                    altariAttivi[2]=1;
                }
            }
        }
    }

    void Start() {
        if(IDaltare == "altTut" && altariAttivi[0] == 1){
            isActivated = true;
            chiave.SetActive(true);
            cerchio.SetActive(true);
        }
        if(IDaltare == "altPass" && altariAttivi[1] == 1){
            isActivated = true;
            chiave.SetActive(true);
            cerchio.SetActive(true);
        }
        if(IDaltare == "altPhis" && altariAttivi[2] == 1){
            isActivated = true;
            chiave.SetActive(true);
            cerchio.SetActive(true);
        }
    }
}
