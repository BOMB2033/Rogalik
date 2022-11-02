using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdownutton : MonoBehaviour
{

    void Start()
    {

    }

    public void change()
    {
        if (gameObject.GetComponent<TMP_Dropdown>().value == 0)
        {
            GameObject.Find("Controller").GetComponent<ControlScript>().isAutoShot = false;
        }
        else
        {
            GameObject.Find("Controller").GetComponent<ControlScript>().isAutoShot = true;

        }
    }
}
