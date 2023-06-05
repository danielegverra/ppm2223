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
    public GameObject personaggio;
    public GameObject camera;
    public static int clickRisposta = 4;

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                personaggio.SetActive(false);
                camera.SetActive(false);
                pulsanteInterazione.SetActive(false);
                mostraDomanda();
                //Inventario.obiettiviTut[1] = "";
            }

        }
        if(clickRisposta != 4 && isClose) {
            if(IDporta=="portaPass1"){
                if(clickRisposta == 1){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass2"){
                if(clickRisposta == 3){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass3"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass4"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass5"){
                if(clickRisposta == 3){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass6"){
                if(clickRisposta == 3){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass7"){
                if(clickRisposta == 1){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass8"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass9"){
                if(clickRisposta == 3){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass10"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass11"){
                if(clickRisposta == 1){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            } else if(IDporta=="portaPass12"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    animator.SetTrigger("character_nearby");
                    clickRisposta = 4;
                    camera.SetActive(true);
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }
            clickRisposta = 4;
        }
    }

    void mostraDomanda(){
        if(IDporta == "portaPass1") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale tra queste è la migliore contromisura per proteggere le tue password?");
            testoRisposta1.SetText("Cambiarle spesso");
            testoRisposta2.SetText("Scriverle su un file sul desktop");
            testoRisposta3.SetText("Scriverle su un foglietto di carta"); 
            riquadroDomanda.SetActive(true);
        } else if(IDporta == "portaPass2") {
            Cursor.visible = true;
            testoDomanda.SetText("Qual è il miglior approccio per creare una password sicura?");
            testoRisposta1.SetText("Scegliere una frase di lunghezza significativa che includa parole chiave.");
            testoRisposta2.SetText("Utilizzare una password basata sul proprio nome e data di nascita.");
            testoRisposta3.SetText("Utilizzare una combinazione casuale di lettere, numeri e caratteri speciali.");
            riquadroDomanda.SetActive(true);
        } else if(IDporta == "portaPass3") {
            Cursor.visible = true;
            testoDomanda.SetText("E consigliabile utilizzare password uniche per ogni account?");
            testoRisposta1.SetText("No, perchè è piu difficile ricordarsele");
            testoRisposta2.SetText("Si, perchè si riduce la possibilità di essere scoperti");
            testoRisposta3.SetText("No, perchè ci si confonde facilmente");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass4") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è meno sicura?");
            testoRisposta1.SetText("AbCdEfG123");
            testoRisposta2.SetText("qwertyuiop");
            testoRisposta3.SetText("SuperSecurePassword");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass5") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è meno sicura?");
            testoRisposta1.SetText("SunnyDay2023");
            testoRisposta2.SetText("!@#$%^&*");
            testoRisposta3.SetText("football123");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass6") {
            Cursor.visible = true;
            testoDomanda.SetText("Come posso proteggere le mie password da attacchi di hacking?");
            testoRisposta1.SetText("Utilizzare la stessa password per tutti gli account per semplificare la memorizzazione.");
            testoRisposta2.SetText("Utilizzare autenticazione a due fattori (2FA) per un ulteriore livello di sicurezza.");
            testoRisposta3.SetText("Condividere le password con amici o colleghi fidati per una maggiore sicurezza.");
            riquadroDomanda.SetActive(true); 
        }
        else if(IDporta == "portaPass7") {
            Cursor.visible = true;
            testoDomanda.SetText("Cosa devo fare se sospetto che la mia password sia stata compromessa?");
            testoRisposta1.SetText("Cambiare immediatamente la password per l'account interessato.");
            testoRisposta2.SetText("Ignorare il sospetto e continuare a utilizzare la stessa password.");
            testoRisposta3.SetText("Informare solo gli amici o familiari più stretti della possibile violazione.");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass8") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è più sicura?");
            testoRisposta1.SetText("FootballFan");
            testoRisposta2.SetText("P@$$w0rd2023");
            testoRisposta3.SetText("ilovemusic");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass9") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale tra queste è una caratteristica fondamentale per una password forte?");
            testoRisposta1.SetText("Utilizzo di pochi caratteri");
            testoRisposta2.SetText("Facile da ricordare");
            testoRisposta3.SetText("Utilizzo di numeri lettere e caratteri speciali");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass10") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è meno sicura?");
            testoRisposta1.SetText("Secure123!");
            testoRisposta2.SetText("password123");
            testoRisposta3.SetText("MyBday12");
            riquadroDomanda.SetActive(true); 
        }
        else if(IDporta == "portaPass11") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è più sicura?");
            testoRisposta1.SetText("Passw0rd!");
            testoRisposta2.SetText("ILovePizza");
            testoRisposta3.SetText("1234abcd");
            riquadroDomanda.SetActive(true);
        }
        else if(IDporta == "portaPass12") {
            Cursor.visible = true;
            testoDomanda.SetText("Quale delle seguenti opzioni di password è più sicura?");
            testoRisposta1.SetText("summer2023");
            testoRisposta2.SetText("S#m3r20!");
            testoRisposta3.SetText("mypassword");
            riquadroDomanda.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
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

    public void clickRisposta1() {
        clickRisposta = 1;
    }

    public void clickRisposta2() {
        clickRisposta = 2;
    }

    public void clickRisposta3() {
        clickRisposta = 3;
    }

    public void perdiVita() {
        ControlloHp.hpInt--;
    }

}
