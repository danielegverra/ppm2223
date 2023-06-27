using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cartello : MonoBehaviour
{
    public GameObject pulsanteInterazione;
    public GameObject pulsanteAvvisoDialogo;
    bool isClose=false;
    public string[] lines;
    public float textSpeed;
    public GameObject casellaDialogo;
    public TextMeshProUGUI textComponent;
    private int index;
    bool thisDialogueActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isClose) {
            if (Input.GetKeyDown(KeyCode.E) && Dialogue.hasReadDialogues) {
                casellaDialogo.SetActive(true);
                thisDialogueActive = true;
                textComponent.text = string.Empty;
                Audio.audio = 6;
                StartDialogue();
                pulsanteInterazione.SetActive(false);
            }
        }
        if (Input.GetMouseButtonDown(0) && !Dialogue.hasReadDialogues && thisDialogueActive) {
            if (textComponent.text == lines[index]) {
                NextLine();
            }
            else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && Dialogue.hasReadDialogues){
            pulsanteInterazione.SetActive(true);
            isClose = true;
        } else if(other.gameObject.CompareTag("Player") && !Dialogue.hasReadDialogues){
            pulsanteAvvisoDialogo.SetActive(true);
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pulsanteInterazione.SetActive(false);
            pulsanteAvvisoDialogo.SetActive(false);
            isClose = false;
        }
    }

    void StartDialogue() {
        Dialogue.hasReadDialogues = false;
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
            thisDialogueActive = false;
            Dialogue.hasReadDialogues = true;
        }
    }
}
