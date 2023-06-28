using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DatiGioco
{
    [SerializeField]
    public string slot = "0";

    [SerializeField]
    public string nomeGiocatore;

    [SerializeField]
    public string stanza;

    [SerializeField]
    public int punteggio;

    [SerializeField]
    public int[] altari;

    [SerializeField]
    public int[] vettoreInv;

    public DatiGioco(string save, string name, string room, int points, int[] altars, int[] inv)
    {
        slot = save;
        nomeGiocatore = name;
        stanza = room;
        punteggio = points;
        altari = altars;
        vettoreInv = inv;
    }
}

