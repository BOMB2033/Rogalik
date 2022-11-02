using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public Sprite[] weapon = new Sprite[5];
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameObject.Find("Controller").GetComponent<ControlScript>().weapon1)
        {
            case TypeWeapons.empty:
                sp.sprite = weapon[0];
                break;
            case TypeWeapons.Revolver:
                sp.sprite = weapon[1];
                break;
            case TypeWeapons.Ak69:
                sp.sprite = weapon[2];
                break;
            case TypeWeapons.Nagelwerfer:
                sp.sprite = weapon[3];
                break;
            case TypeWeapons.Pyras:
                sp.sprite = weapon[4];
                break;
        }
       
    }
}
