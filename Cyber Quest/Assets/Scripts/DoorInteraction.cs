using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour {
    private bool isClose = false;
    public GameObject pulsanteInterazione;
    public GameObject trigger;
    public Animator animator;
    public string IDporta; 

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && IDporta == "portaTut") {
                trigger.SetActive(false);
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                Inventario.obiettiviTut[1] = "";
            }
            if (Input.GetKeyDown(KeyCode.E) && IDporta == "portaPass") {
                trigger.SetActive(false);
                SceneManager.LoadScene("PasswordAmbientazione");
                pulsanteInterazione.SetActive(false);
            }
            if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhis"){
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                trigger.SetActive(false);
            }if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhisLivello"){
                pulsanteInterazione.SetActive(false);
                SceneManager.LoadScene("PhishingAmbientazione");
                trigger.SetActive(false);
            }

        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && IDporta == "portaTut" && ChiaveTutorial.hasReadDialoguesKey) {
            Interact();
        }
        if (other.gameObject.CompareTag("Player") && IDporta != "portaTut") {
            Interact();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pulsanteInterazione.SetActive(false);
            isClose = false;
        }
    }

    public void Interact() {
        pulsanteInterazione.SetActive(true);
        isClose = !isClose;
    }

    

}
