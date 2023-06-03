
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{

    bool isopen;
    public static int[] vettoreInv = {0,0,0,0,0,0,0};

    public static string[] obiettiviTut = {"Prendi la chiave", "Apri la porta", "Entra nel cerchio magico"};
    public static string[] obiettiviHub = {"Termina le 3 prove", "Attiva i 4 altari" , "Apri il portone"};
    public static string[] obiettiviPass = {"trova la chiave del portone", "trova il potenziamento", "raccogli i collezionabili"};
    public static string[] obiettiviPhis = {"impedisci al ladro di rubare", "raccogli i collezionabili"};
    public static string[] obiettiviMalw = {"difendi il nucleo", "raccogli i collezionabili"};


    public GameObject chiaveTut;
    public GameObject chiavePass;
    public GameObject chiavePhis;
    public GameObject chiaveMalw;
    public GameObject veleno;
    public GameObject mascherina;
    public GameObject occhiali;
    public GameObject inventario;

    public TextMeshProUGUI testoObiettivo;


    void Start()
    {
        isopen=false;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            if(!isopen){
                controllaPresenze();
                cambiaObiettivi();
                inventario.SetActive(true);
                isopen=true;
            }
            else{
                inventario.SetActive(false);
                isopen=false;
            }
        }
    }

    void cambiaObiettivi(){
        string obVisualizzato ="";
        if(SceneManager.GetActiveScene().name == "Tutorial"){
            foreach (string obiettivo in obiettiviTut){
                if (obiettivo != "" ){
                    obVisualizzato += obiettivo;
                    obVisualizzato += "\n\n"; 
                }
            }
        }
        if(SceneManager.GetActiveScene().name == "HubCentrale"){
            foreach (string obiettivo in obiettiviHub){
                if (obiettivo != "" ){
                    obVisualizzato += obiettivo;
                    obVisualizzato += "\n\n"; 
                }
            }
        }
        


        testoObiettivo.SetText(obVisualizzato);
    }

    void controllaPresenze(){
        if(vettoreInv[0]==1){
            chiaveTut.SetActive(true);
        }
        if(vettoreInv[1]==1){
            chiavePass.SetActive(true);
        }
        if(vettoreInv[2]==1){
            chiavePhis.SetActive(true);
        }
        if(vettoreInv[3]==1){
            chiaveMalw.SetActive(true);
        }
        if(vettoreInv[4]==1){
            veleno.SetActive(true);
        }
        if(vettoreInv[5]==1){
            mascherina.SetActive(true);
        }
        if(vettoreInv[6]==1){
            occhiali.SetActive(true);
        }
    }

}
