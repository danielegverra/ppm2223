using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NomiClassifica : MonoBehaviour
{
    public TextMeshProUGUI slot1nome;
    public TextMeshProUGUI slot1punti;
    public TextMeshProUGUI slot2nome;
    public TextMeshProUGUI slot2punti;
    public TextMeshProUGUI slot3nome;
    public TextMeshProUGUI slot3punti;

    // Start is called before the first frame update
    void Start()
    {
        setNomiClassifica();
    }

    public void setNomiClassifica(){
        string tmpSave;
        DatiGioco caricamento;
        int[] numOrd = new int[3];
        string[] nameOrd = new string[3];
        if (PlayerPrefs.HasKey("salvataggio_1")){
            tmpSave = PlayerPrefs.GetString("salvataggio_1");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            numOrd[0] = caricamento.punteggio;
            nameOrd[0] = caricamento.nomeGiocatore;
        } else {
            numOrd[0] = 0;
            nameOrd[0] = "Player slot 1";
        }
        if (PlayerPrefs.HasKey("salvataggio_2")){
            tmpSave = PlayerPrefs.GetString("salvataggio_2");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            numOrd[1] = caricamento.punteggio;
            nameOrd[1] = caricamento.nomeGiocatore;
        } else {
            numOrd[1] = 0;
            nameOrd[1] = "Player slot 2";
        }
        if (PlayerPrefs.HasKey("salvataggio_3")){
            tmpSave = PlayerPrefs.GetString("salvataggio_3");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            numOrd[2] = caricamento.punteggio;
            nameOrd[2] = caricamento.nomeGiocatore;
        } else {
            numOrd[2] = 0;
            nameOrd[2] = "Player slot 3";
        }
        for (int i = 0; i < numOrd.Length - 1; i++)
        {
            for (int j = i + 1; j < numOrd.Length; j++)
            {
                if (numOrd[i] < numOrd[j])
                {
                    // Scambia gli elementi nel primo vettore
                    int temp = numOrd[i];
                    numOrd[i] = numOrd[j];
                    numOrd[j] = temp;

                    // Scambia gli elementi nel secondo vettore
                    string tempString = nameOrd[i];
                    nameOrd[i] = nameOrd[j];
                    nameOrd[j] = tempString;
                }
            }
        }
        slot1nome.text = nameOrd[0];
        slot1punti.text = "" + numOrd[0];
        slot2nome.text = nameOrd[1];
        slot2punti.text = "" + numOrd[1];
        slot3nome.text = nameOrd[2];
        slot3punti.text = "" + numOrd[2];
    }
}
