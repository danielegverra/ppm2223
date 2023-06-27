using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlloHp : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public static int hpInt;
    public static int pointIngresso;
    public GameObject domanda;
    public GameObject morto;
    public bool isDead = false;


    // Start is called before the first frame update
    void Start()
    {
        pointIngresso = Inventario.nPoints;
        hpInt = int.Parse(hp.text);
    }

    // Update is called once per frame
    void Update()
    {
        hp.SetText(hpInt.ToString());
        if(hpInt == 0 && !isDead) {
            Audio.audio = 8;
            morto.SetActive(true);
            domanda.SetActive(false);
            isDead = true;
        }
        if (isDead && Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().name == "PasswordAmbientazione") {
            Inventario.obiettiviPass[0] = "Trova la chiave del portone";
            Inventario.obiettiviPass[1] = "Trova il potenziamento";
            Inventario.vettoreInv[1] = 0;
            Inventario.vettoreInv[4] = 0;
            Inventario.nPoints = pointIngresso;
            SceneManager.LoadScene("PasswordAmbientazione");
        }
        if (isDead && Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().name == "PhishingAmbientazione") {
            Inventario.obiettiviPass[0] = "Completa il puzzle";
            Inventario.obiettiviPass[1] = "Trova la chiave del portone";
            Inventario.vettoreInv[2] = 0;
            Inventario.nPoints = pointIngresso;
            SceneManager.LoadScene("PhishingAmbientazione");
        }

    }
}
