using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

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

}
