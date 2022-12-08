using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlShots : MonoBehaviour
{
    public Joystick joystick;
    private GameObject pl;
    public GameObject bulet;
    public GameObject bulett;
    public float delay = 0.5f; //��� ��� ���� ���� int,double ��� float

    private bool delayState = true;
    private bool isShotTrue = false;

    IEnumerator Delay()
    {
        delayState = false;
        var g = Instantiate(bulet);
        g.transform.position = bulett.transform.position;
        g.transform.rotation = bulett.transform.rotation;
        yield return new WaitForSeconds(delay); //�� ����� ��������� ��������.
       
        delayState = true;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            if (joystick.Horizontal > 0) {
                pl.GetComponent<SpriteRenderer>().flipX = false; // �������� �� �
                gameObject.transform.localScale = new Vector2(Math.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y);
                gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, (float)Math.Atan2(joystick.Vertical, joystick.Horizontal) * 60);
            }
            else {
                pl.GetComponent<SpriteRenderer>().flipX = true; // �������� �� �
                gameObject.transform.localScale = new Vector2(-Math.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y);
                gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, 180 + (float)Math.Atan2(joystick.Vertical, joystick.Horizontal) * 60);
            }
        }
        // Weapon.transform.rotation = Quaternion.Euler

    }

    void FixedUpdate()
    {
        if(GameObject.Find("Controller").GetComponent<ControlScript>().weapon1 != TypeWeapons.empty &&
         SceneManager.GetActiveScene().name != "Hub" && 
         GameObject.Find("cooldown").GetComponent<CDWeapon>().isCd){
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
          GameObject.Find("cooldown").GetComponent<CDWeapon>().isCd =  false;
          GameObject.Find("cooldown").GetComponent<CDWeapon>().cd =  100f;
          if (delayState) //�������� � ������ �����
              StartCoroutine(Delay()); 
        }
        }
    }
}
    