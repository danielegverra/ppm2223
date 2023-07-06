using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour {
    public TextMeshProUGUI textComponent;
    public static bool hasReadDialogues;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start() {
        hasReadDialogues = false;
        if(SceneManager.GetActiveScene().name == "HubCentrale" && Inventario.vettoreInv[1] + Inventario.vettoreInv[2] > 0){
            lines = new string[]{};
            hasReadDialogues = true;
            gameObject.SetActive(false);
        } else {
            textComponent.text = string.Empty;
            StartDialogue();
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0) && lines.Length > 0) {
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
            gameObject.SetActive(false);
            hasReadDialogues = true;
            lines = new string[]{};
        }
    }
}
