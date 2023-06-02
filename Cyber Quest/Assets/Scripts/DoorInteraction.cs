using UnityEngine;

public class DoorInteraction : MonoBehaviour {
    private bool isClose = false;
    public GameObject pulsanteInterazione;
    public GameObject trigger;
    public Animator animator;

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                trigger.SetActive(false);
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
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
