using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TV : MonoBehaviour
{

    private bool isClose = false;
    public GameObject pulsanteInterazione;
    public GameObject trigger;
    public GameObject chiave;

    public string IDtv; 

    public TextMeshProUGUI testoDomanda;
    public TextMeshProUGUI testoRisposta1;
    public TextMeshProUGUI testoRisposta2;

    public GameObject riquadroDomanda;
    public GameObject personaggio;
    public GameObject camera;

    public static int clickRisposta = 3;
    public static int tvIndovinate = 0;

    public GameObject imageul1;
    public GameObject imageul2;
    public GameObject imageul3;
    public GameObject imageul4;
    public GameObject imageur1;
    public GameObject imageur2;
    public GameObject imageur3;
    public GameObject imageur4;
    public GameObject imagedl1;
    public GameObject imagedl2;
    public GameObject imagedl3;
    public GameObject imagedl4;
    public GameObject imagedr1;
    public GameObject imagedr2;
    public GameObject imagedr3;
    public GameObject imagedr4;

    // Update is called once per frame
    void Update()
    {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                personaggio.SetActive(false);
                camera.SetActive(false);
                pulsanteInterazione.SetActive(false);
                Audio.audio = 7;
                mostraDomanda();
            }

        }
        if(clickRisposta != 3 && isClose) {
            if(IDtv=="tv1"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    clickRisposta = 3;
                    camera.SetActive(true);
                    Inventario.nPoints += 10;
                    Audio.audio = 4;
                    Cursor.visible = false;
                    tvIndovinate++;
                    imageul1.SetActive(true);
                    imageul2.SetActive(true);
                    imageul3.SetActive(true);
                    imageul4.SetActive(true);
                    if(tvIndovinate == 4){
                        chiave.SetActive(true);
                    }
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }
            else if(IDtv=="tv2"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    clickRisposta = 3;
                    camera.SetActive(true);
                    Inventario.nPoints += 10;
                    Audio.audio = 4;
                    Cursor.visible = false;
                    tvIndovinate++;
                    imageur1.SetActive(true);
                    imageur2.SetActive(true);
                    imageur3.SetActive(true);
                    imageur4.SetActive(true);
                    if(tvIndovinate == 4){
                        chiave.SetActive(true);
                    }
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }else if(IDtv=="tv3"){
                if(clickRisposta == 2){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    clickRisposta = 3;
                    camera.SetActive(true);
                    Inventario.nPoints += 10;
                    Audio.audio = 4;
                    Cursor.visible = false;
                    tvIndovinate++;
                    imagedl1.SetActive(true);
                    imagedl2.SetActive(true);
                    imagedl3.SetActive(true);
                    imagedl4.SetActive(true);
                    if(tvIndovinate == 4){
                        chiave.SetActive(true);
                    }
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }
            else if(IDtv=="tv4"){
                if(clickRisposta == 1){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    clickRisposta = 3;
                    camera.SetActive(true);
                    Inventario.nPoints += 10;
                    Audio.audio = 4;
                    Cursor.visible = false;
                    tvIndovinate++;
                    imagedr1.SetActive(true);
                    imagedr2.SetActive(true);
                    imagedr3.SetActive(true);
                    imagedr4.SetActive(true);
                    if(tvIndovinate == 4){
                        chiave.SetActive(true);
                    }
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }
            clickRisposta=3;
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

    void mostraDomanda(){
        if(IDtv == "tv1") {
            Cursor.visible = true;
            testoDomanda.SetText("Qual è una misura di sicurezza consigliata per proteggersi dal phishing?");
            testoRisposta1.SetText("Fare clic su tutti i link in arrivo per verificare se sono autentici");
            testoRisposta2.SetText("Verificare l'URL di un sito web prima di inserire informazioni personali");
            riquadroDomanda.SetActive(true);
        } else if(IDtv == "tv2") {
            Cursor.visible = true;
            testoDomanda.SetText("Qual è un modo efficace per verificare la sicurezza di un sito web prima di inserire informazioni sensibili?");
            testoRisposta1.SetText("Condividere liberamente le informazioni richieste per accedere al sito");
            testoRisposta2.SetText("Controllare se il sito web utilizza il protocollo HTTPS");
            riquadroDomanda.SetActive(true);
        } else if(IDtv == "tv3") {
            Cursor.visible = true;
            testoDomanda.SetText("Cosa potrebbe indicare una pagina di accesso di phishing?");
            testoRisposta1.SetText("L'utilizzo di colori vivaci e attraenti sulla pagina");
            testoRisposta2.SetText("L'assenza del logo dell'azienda o di elementi di branding");
            riquadroDomanda.SetActive(true);
        } else if(IDtv == "tv4") {
            Cursor.visible = true;
            testoDomanda.SetText("Cosa potrebbe accadere se si cade vittima di un attacco di phishing?");
            testoRisposta1.SetText("I tuoi dati personali potrebbero essere rubati e utilizzati per scopi fraudolenti");
            testoRisposta2.SetText("Potresti ricevere più spam nella tua casella di posta elettronica");
            riquadroDomanda.SetActive(true);
        }
    }

    public void perdiVita() {
        Inventario.nPoints -= 5;
        ControlloHp.hpInt--;
        Audio.audio = 5;
    }
}
