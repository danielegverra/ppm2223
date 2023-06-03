using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PortePassword : MonoBehaviour {
    private bool isClose = false;
    public GameObject pulsanteInterazione;
    public GameObject trigger;
    public Animator animator;
    public string IDporta; 
    public TextMeshProUGUI testoDomanda;
    public TextMeshProUGUI testoRisposta1;
    public TextMeshProUGUI testoRisposta2;
    public TextMeshProUGUI testoRisposta3;
    public GameObject riquadroDomanda;
    public int clickRisposta = null;

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                //ferma omino
                trigger.SetActive(false);
                animator.SetTrigger("character_nearby");
                pulsanteInterazione.SetActive(false);
                mostraDomanda();
                //Inventario.obiettiviTut[1] = "";
            }

        }
        if(clickRisposta){
            if(IDporta=="postaPass1"){
                if(clickRisposta == 3){
                    //apri porta con animazione    
                }else{
                    //risposta sbagliata, perdi vita
                }
                clickRisposta = null;
            }
            //altri if con le altre  IDporta==portapass2 
        }
    }

    void mostraDomanda(){
        if(IDporta == "portaPass1"){
            Cursor.visible = true;
            testoDomanda.SetText("Quanto è gay Niciola?");
            testoRisposta1.SetText("tanto");
            testoRisposta2.SetText("esagerato");
            testoRisposta3.SetText("incalcolabile");
            riquadroDomanda.SetActive(true);
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
