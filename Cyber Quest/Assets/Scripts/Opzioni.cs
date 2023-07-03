using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Opzioni : MonoBehaviour {
    //public TMP_Dropdown dropdown;

    [SerializeField] public int newValue = 1;
    [SerializeField] public int width = 1920;
    [SerializeField] public int height = 1080;
    [SerializeField] public bool fullscreen = true;

    public TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start() {
        //dropdown.SetValueWithoutNotify(newValue);

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++) {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height) {
                    currentResolutionIndex = i;
                }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetResolution (int resolutionIndex) {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, fullscreen);
    }

    /*
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
    */
}
