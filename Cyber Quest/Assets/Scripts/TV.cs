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

    // Update is called once per frame
    void Update()
    {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                personaggio.SetActive(false);
                camera.SetActive(false);
                pulsanteInterazione.SetActive(false);
                mostraDomanda();
            }

        }
        if(clickRisposta != 3 && isClose) {
            if(IDtv=="tv1"){
                if(clickRisposta == 1){
                    personaggio.SetActive(true);
                    riquadroDomanda.SetActive(false);
                    clickRisposta = 3;
                    camera.SetActive(true);
                    Inventario.nPoints += 10;
                    tvIndovinate++;
                    if(tvIndovinate == 4){
                        chiave.SetActive(true);
                    }
                    trigger.SetActive(false);
                } else {
                    perdiVita();
                }
            }
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
            testoDomanda.SetText("Ma quanto è gay fra?");
            testoRisposta1.SetText("Tantissimissimo");
            testoRisposta2.SetText("Si");
            riquadroDomanda.SetActive(true);
        }
    }

    public void perdiVita() {
        Inventario.nPoints -= 5;
        ControlloHp.hpInt--;
    }
}
