
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{

    //Dictionary<GameObject, int> inv = new Dictionary<GameObject, int>();
    bool isopen;
    public static int[] vettoreInv = new int[2];

    public GameObject chiaveTut;
    public GameObject chiavePass;
    public GameObject inventario;



    void Start()
    {
        vettoreInv[0]=0;
        vettoreInv[1]=0;
        isopen=false;

    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            if(!isopen){
                controllaPresenze();
                inventario.SetActive(true);
                isopen=true;
            }
            else{
                inventario.SetActive(false);
                isopen=false;
            }
        }
    }

    void controllaPresenze(){
        if(vettoreInv[0]==1){
            chiaveTut.SetActive(true);
        }
        if(vettoreInv[1]==1){
            chiavePass.SetActive(true);
        }
    }

}
