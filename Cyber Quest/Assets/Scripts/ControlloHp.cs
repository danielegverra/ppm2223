using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlloHp : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public static int hpInt;



    // Start is called before the first frame update
    void Start()
    {
        hpInt = int.Parse(hp.text);
    }

    // Update is called once per frame
    void Update()
    {
        hp.SetText(hpInt.ToString());
        if(hpInt == 0) {
            // FAGLI PERDERE LA PARTITA
            Debug.Log("SI MUERT");
        }

    }
}
