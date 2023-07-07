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
            if (Input.GetKeyDown(KeyCode.E) && IDporta == "portaPass" && Dialogue.hasReadDialogues && Inventario.vettoreInv[1] == 0) {
                Audio.audio = 0;
                trigger.SetActive(false);
                Salvataggi.SalvaGioco("PasswordAmbientazione");
                SceneManager.LoadScene("PasswordAmbientazione");
                pulsanteInterazione.SetActive(false);
            }
            if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhis" && Dialogue.hasReadDialogues){
                Audio.audio = 0;
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                trigger.SetActive(false);
            }if(Input.GetKeyDown(KeyCode.E) && IDporta == "portaPhisLivello" && Dialogue.hasReadDialogues && Inventario.vettoreInv[2] == 0){
                Audio.audio = 0;
                pulsanteInterazione.SetActive(false);
                Salvataggi.SalvaGioco("PhishingAmbientazione");
                SceneManager.LoadScene("PhishingAmbientazione");
                trigger.SetActive(false);
            }if(Input.GetKeyDown(KeyCode.E) && IDporta == "portoneFinale" && Altare.numeroPortaliAttivati == 3 && Dialogue.hasReadDialogues){
                Audio.audio = 0;
                pulsanteInterazione.SetActive(false);
                ControlloHp.hpInt = 5;
                Cursor.visible = true;
                Salvataggi.SalvaGioco("HubCentrale");
                trigger.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && IDporta == "portaTut" && ChiaveTutorial.hasReadDialoguesKey) {
            Interact();
        }
        if (other.gameObject.CompareTag("Player") && IDporta != "portaTut" && IDporta != "portoneFinale") {
            if(IDporta == "portaPass" && Inventario.vettoreInv[1] == 0){
                Interact();    
            }
            if(IDporta == "portaPhisLivello" && Inventario.vettoreInv[2] == 0){
                Interact();    
            }
            if(IDporta != "portaPhisLivello" && IDporta != "portaPass"){
                Interact();    
            }
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
