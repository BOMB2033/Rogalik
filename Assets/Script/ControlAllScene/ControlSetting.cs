using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ControlSetting : MonoBehaviour
{
    public float volume;
    public int graficValue;
    public bool isOnMusic;
	private TMP_Dropdown qualityDropdown;
    private Slider slider;
    private NewScene newScene;
    // Start is called before the first frame update
    void Start()
    {
        newScene = GameObject.Find("NewScene").GetComponent<NewScene>();
        slider = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        qualityDropdown = GameObject.Find("DropdownGrafic").GetComponent<TMP_Dropdown>();
        GameObject.Find("PanelConfig").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("NewScene") != null)
        {

            if(newScene.isNewScene)
            {
                    newScene.isNewScene = false;
                    qualityDropdown.value = graficValue;
                    slider.value = volume;
            }
            graficValue = qualityDropdown.value;
            
            volume = slider.value;
        }
    }
}
