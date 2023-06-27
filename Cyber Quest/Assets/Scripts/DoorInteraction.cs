using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour {
    private bool isClose = false;
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    public GameObject trigger;
    public Animator animator;
    public string IDporta; 

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && IDporta == "portaTut" && Dialogue.hasReadDialogues) {
                Audio.audio = 0;
                trigger.SetActive(false);
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                Inventario.obiettiviTut[1] = "";
            }
            if (Input.GetKeyDown(KeyCode.E) && IDporta == "portaPass" && Dialogue.hasReadDialogues) {
                Audio.audio = 0;
                // DA RISOLVERE
                //trigger.SetActive(false);
                SceneManager.LoadScene("PasswordAmbientazione");
                pulsanteInterazione.SetActive(false);
            }
            if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhis" && Dialogue.hasReadDialogues){
                Audio.audio = 0;
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                trigger.SetActive(false);
            }if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhisLivello" && Dialogue.hasReadDialogues){
                Audio.audio = 0;
                pulsanteInterazione.SetActive(false);
                SceneManager.LoadScene("PhishingAmbientazione");
                trigger.SetActive(false);
            }if(Input.GetKeyDown(KeyCode.E) && IDporta == "portoneFinale" && Altare.numeroPortaliAttivati == 3 && Dialogue.hasReadDialogues){
                Audio.audio = 0;
                pulsanteInterazione.SetActive(false);
                SceneManager.LoadScene("Menu");
                trigger.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && IDporta == "portaTut" && ChiaveTutorial.hasReadDialoguesKey) {
            Interact();
        }
        if (other.gameObject.CompareTag("Player") && IDporta != "portaTut" && IDporta != "portoneFinale") {
            Interact();
        }
        if (other.gameObject.CompareTag("Player") && IDporta == "portoneFinale" && Altare.numeroPortaliAttivati == 3){
            Interact();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pulsanteInterazione.SetActive(false);
            pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    public void Interact() {
        if (Dialogue.hasReadDialogues){
            pulsanteInterazione.SetActive(true);
        } else {
            pulsanteAvvisoDialogo.SetActive(true);
        }
        isClose = true;
    }

}
