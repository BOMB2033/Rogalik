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
	public TMP_Dropdown qualityDropdown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("NewScene") != null)
        {

            if(GameObject.Find("NewScene").GetComponent<NewScene>().isNewScene)
            {
                    GameObject.Find("NewScene").GetComponent<NewScene>().isNewScene = false;
                    GameObject.Find("DropdownGrafic").GetComponent<TMP_Dropdown>().value = graficValue;
                    GameObject.Find("VolumeSlider").GetComponent<Slider>().value = volume;
            }
            graficValue = GameObject.Find("DropdownGrafic").GetComponent<TMP_Dropdown>().value;
            volume = GameObject.Find("VolumeSlider").GetComponent<Slider>().value;
        }
    }
}
