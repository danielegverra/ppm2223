using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletrasporto : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    bool isClose=false;
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pulsanteInterazione.SetActive(false);
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                Inventario.nPoints += 10;
                vaiHubCentrale();
            }
        }
    }

    public void vaiHubCentrale(){
        SceneManager.LoadScene("HubCentrale");
    }
}
