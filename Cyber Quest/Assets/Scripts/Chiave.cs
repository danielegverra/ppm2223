using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chiave : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    public GameObject trigger;
    public GameObject chiave;
    //public GameObject iconaChiave;
    bool istaken = false;
    bool isClose=false;

    public TextMeshProUGUI textComponent;
    public static bool hasReadDialoguesKey = false;
    public string[] lines;
    public float textSpeed;
    public GameObject casellaDialogo;

    private int index;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && Dialogue.hasReadDialogues && !istaken){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        }else if(other.gameObject.CompareTag("Player") && !Dialogue.hasReadDialogues && !istaken){
            pulsanteAvvisoDialogo.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player") && !istaken) {
            pulsanteInterazione.SetActive(false);
            pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    private void Update() {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && !istaken) {
                casellaDialogo.SetActive(true);
                textComponent.text = string.Empty;
                StartDialogue();
                pulsanteInterazione.SetActive(false);
                istaken = true;
                chiave.SetActive(false);
                Inventario.vettoreInv[0] = 1;
                //iconaChiave.SetActive(true);
            }
        }
        if (Input.GetMouseButtonDown(0) && Dialogue.hasReadDialogues) {
            if (textComponent.text == lines[index]) {
                NextLine();
            }
            else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue() {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() {
        foreach (char c in lines[index].ToCharArray()) {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        if (index < lines.Length - 1) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else {
            casellaDialogo.SetActive(false);
            hasReadDialoguesKey = true;
        }
    }
}
