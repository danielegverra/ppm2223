using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI casellaNome;
    public GameObject casella;

    public void vaiMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void vaiNuovaPartita(){
        SceneManager.LoadScene("NuovaPartita");
    }

    public void vaiTutorial(){
        SceneManager.LoadScene("Tutorial");
        Cursor.visible = false;
    }

    public void vaiCaricaPartita(){
        SceneManager.LoadScene("CaricaPartita");
    }

    public void vaiClassifica(){
        SceneManager.LoadScene("Classifica");
    }

    public void vaiOpzioni(){
        SceneManager.LoadScene("Opzioni");
    }

    public void vaiCrediti(){
        SceneManager.LoadScene("Crediti");
    }

    public void esci(){
        Application.Quit();
    }

    public void setSlot(string number){
        Inventario.slot = number;
    }

    public void setName(){
        string nome = casellaNome.text;
        if(nome == ""){
            nome = "Player " + Inventario.slot;
        }
        Inventario.nomeGiocatore = nome;
    }

    public void apriCasellaNome(){
        casella.SetActive(true);
    }

    public void rumorinoBottone(){
        GetComponents<AudioSource>()[0].Play();
    }

}
