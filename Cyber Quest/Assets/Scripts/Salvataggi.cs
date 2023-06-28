using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Salvataggi
{
    public static void SalvaGioco()
    {
        DatiGioco salvataggio = new DatiGioco(Inventario.slot, Inventario.nomeGiocatore,
            SceneManager.GetActiveScene().name, Inventario.nPoints, Altare.altariAttivi,
            Inventario.vettoreInv);
        string datiJson = JsonUtility.ToJson(salvataggio);
        PlayerPrefs.SetString(GetKey(Inventario.slot), datiJson);
        PlayerPrefs.Save();
    }

    public static void CaricaGioco(string nomeSalvataggio)
    {
        string key = GetKey(nomeSalvataggio);
        if (PlayerPrefs.HasKey(key))
        {
            string datiJson = PlayerPrefs.GetString(key);
            DatiGioco caricamento = JsonUtility.FromJson<DatiGioco>(datiJson);
            Inventario.slot = caricamento.slot;
            Inventario.nomeGiocatore = caricamento.nomeGiocatore;
            Inventario.nPoints = caricamento.punteggio;
            Altare.altariAttivi = caricamento.altari;
            Inventario.vettoreInv = caricamento.vettoreInv;
            SceneManager.LoadScene(caricamento.stanza);
        }
    }

    public static void EliminaSalvataggio(string nomeSalvataggio)
    {
        string key = GetKey(nomeSalvataggio);
        if (PlayerPrefs.HasKey(key))
        {
            PlayerPrefs.DeleteKey(key);
            PlayerPrefs.Save();
        }
    }

    private static string GetKey(string nomeSalvataggio)
    {
        return "salvataggio_" + nomeSalvataggio;
    }
}

