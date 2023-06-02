using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Opzioni : MonoBehaviour {
    public TMP_Dropdown dropdown;

    [SerializeField] public int newValue = 1;
    [SerializeField] public int width = 1920;
    [SerializeField] public int height = 1080;
    [SerializeField] public bool fullscreen = true;

    void Start() {
        dropdown.SetValueWithoutNotify(newValue);
    }

    public void TendinaRisoluzioni(int index) {
        switch(index) {
            case 0:
                width = 600;
                height = 400;
                Screen.SetResolution(width, height, fullscreen);
                newValue = 0;
                dropdown.SetValueWithoutNotify(newValue);
                break;
            case 1:
                width = 1920;
                height = 1080;
                Screen.SetResolution(width, height, fullscreen);
                newValue = 1;
                dropdown.SetValueWithoutNotify(newValue);
                break;
            case 2:
                width = 2560;
                height = 1440;
                Screen.SetResolution(width, height, fullscreen);
                newValue = 2;
                dropdown.SetValueWithoutNotify(newValue);
                break;
            case 3:
                width = 3840;
                height = 2160;
                Screen.SetResolution(width, height, fullscreen);
                newValue = 3;
                dropdown.SetValueWithoutNotify(newValue);
                break;
        }
    }
}
