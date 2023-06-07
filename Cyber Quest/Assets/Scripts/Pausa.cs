using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pausa : MonoBehaviour
{
    public static bool inPausa = false;
    public GameObject menuPausa;

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(inPausa){
                Play();
            } else {
                Stop();
            }
        }
    }

    void Stop()
    {
        menuPausa.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        inPausa = true;
    }

    public void Play()
    {
        menuPausa.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
        inPausa = false;
    }

}
