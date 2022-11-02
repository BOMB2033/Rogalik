using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{

    public Button buttonChest;
    public TypeWeapons[] weapons = new TypeWeapons[3];
    private float dist;


    // Start is called before the first frame update
    void Start()
    {
        buttonChest.onClick.AddListener(ClickChestButton);
    }

    // Update is called once per frame

    public void ClickChestButton ()
    {
        buttonChest.gameObject.SetActive(false);
        if (GameObject.FindWithTag("Controller").GetComponent<ControlScript>().weapon1 == TypeWeapons.empty)
        {
            GameObject.FindWithTag("Controller").GetComponent<ControlScript>().weapon1 = weapons[Random.RandomRange(0, weapons.Length)];
        }
        else
        {
            if (GameObject.FindWithTag("Controller").GetComponent<ControlScript>().weapon2 == TypeWeapons.empty)
            {
                GameObject.FindWithTag("Controller").GetComponent<ControlScript>().weapon2 = weapons[Random.RandomRange(0, weapons.Length)];
            }
            else
            {
                
            }
        }
        
        Destroy(gameObject);

    }

    void Update()
    {

        dist = Vector2.Distance(transform.position, GameObject.FindWithTag("Player").transform.position);

        if (dist < 1f)
        {
            buttonChest.gameObject.SetActive(true);
        }
        else
        {
            buttonChest.gameObject.SetActive(false);
        }

    }
}
