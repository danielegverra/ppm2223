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
                Inventario.obiettiviTut[1] = "";
            }


        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && Chiave.hasReadDialoguesKey) {
            Debug.Log("Il player è entrato nel cubo");
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
