using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickShotCS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Controller").GetComponent<ControlScript>().isAutoShot)
        {
            gameObject.active = false;
        }else
            gameObject.active = true;



    }
}
