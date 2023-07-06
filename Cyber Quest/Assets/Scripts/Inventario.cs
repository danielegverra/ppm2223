
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{

    bool isopen;
    public static string slot = "0";
    public static string nomeGiocatore = "Player";
    public static int[] vettoreInv = {0,0,0,0,0,0,0};

    public static float volumeMusica = -15;
    public static float volumeSuoni = -15;

    public static bool bottoneFullScreen = true;

    public static string[] obiettiviTut = {"Prendi la chiave", "Apri la porta", "Entra nel cerchio magico"};
    public static string[] obiettiviHub = {"Termina le 2 prove", "Attiva i 3 altari" , "Apri il portone"};
    public static string[] obiettiviPass = {"Trova la chiave del portone", "Trova il potenziamento", "Raccogli i collezionabili"};
    public static string[] obiettiviPhis = {"Completa il puzzle", "Trova la chiave del portone", "Raccogli i collezionabili"};
    public static string[] obiettiviMalw = {"difendi il nucleo", "raccogli i collezionabili"};
    public static int nPoints = 0;

    public TextMeshProUGUI points;


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
        points.SetText(nPoints.ToString());
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
        if(SceneManager.GetActiveScene().name == "PasswordAmbientazione"){
            foreach (string obiettivo in obiettiviPass){
                if (obiettivo != "" ){
                    obVisualizzato += obiettivo;
                    obVisualizzato += "\n\n"; 
                }
            }
        }
        if(SceneManager.GetActiveScene().name == "PhishingAmbientazione"){
            foreach (string obiettivo in obiettiviPass){
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
