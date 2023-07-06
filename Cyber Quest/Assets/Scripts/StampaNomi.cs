using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StampaNomi : MonoBehaviour
{
    public TextMeshProUGUI slot1;
    public TextMeshProUGUI slot2;
    public TextMeshProUGUI slot3;

    // Start is called before the first frame update
    void Start()
    {
        setNomiSlot();
    }

    public void setNomiSlot(){
        string tmpSave;
        DatiGioco caricamento;
        if (PlayerPrefs.HasKey("salvataggio_1")){
            tmpSave = PlayerPrefs.GetString("salvataggio_1");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            slot1.text = caricamento.nomeGiocatore;
        }
        if (PlayerPrefs.HasKey("salvataggio_2")){
            tmpSave = PlayerPrefs.GetString("salvataggio_2");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            slot2.text = caricamento.nomeGiocatore;
        }
        if (PlayerPrefs.HasKey("salvataggio_3")){
            tmpSave = PlayerPrefs.GetString("salvataggio_3");
            caricamento = JsonUtility.FromJson<DatiGioco>(tmpSave);
            slot3.text = caricamento.nomeGiocatore;
        }
    }
}
