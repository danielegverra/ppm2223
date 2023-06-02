using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletrasporto : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Il player è entrato nel teletrasporto");
            vaiHubCentrale();
        }
    }

    public void vaiHubCentrale(){
        SceneManager.LoadScene("HubCentrale");
    }
}
