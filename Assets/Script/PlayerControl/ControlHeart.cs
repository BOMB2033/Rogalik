using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlHeart : MonoBehaviour
{
    public Sprite[] numbSpriteN = new Sprite[11];
    public Sprite[] numbSpriteG = new Sprite[11];
    public Sprite[] numbSpriteD = new Sprite[11];
    public Sprite[] numbSpriteT = new Sprite[11];

    public GameObject[] numbGumb = new GameObject[2];

    public Sprite[] typeSprite = new Sprite[3];
    public GameObject typeHeart;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    private void numbDraw(int i, Sprite[] numbSprite)
    {
        if (i > 9)
        {
            numbGumb[0].GetComponent<Image>().sprite = numbSprite[
                    (i - (i % 10))/10];

                numbGumb[1].GetComponent<Image>().sprite = numbSprite[i % 10];
            
        }
        else
        {
            numbGumb[0].GetComponent<Image>().sprite = numbSprite[i % 10];
            numbGumb[1].GetComponent<Image>().sprite = numbSprite[10];
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        switch (GameObject.Find("Controller").GetComponent<ControlScript>().heart)
        {
            case TypeHeart.Normal:
                typeHeart.GetComponent<Image>().sprite = typeSprite[0];
                numbDraw(GameObject.Find("Controller").GetComponent<ControlScript>()._hp, numbSpriteN);
                break;
            case TypeHeart.GoldHeart:
                typeHeart.GetComponent<Image>().sprite = typeSprite[1];
                numbDraw(GameObject.Find("Controller").GetComponent<ControlScript>()._hp, numbSpriteG);
                break;
            case TypeHeart.DarkHeart:
                typeHeart.GetComponent<Image>().sprite = typeSprite[2];
                numbDraw(GameObject.Find("Controller").GetComponent<ControlScript>()._hp, numbSpriteD);
                break;
            case TypeHeart.TimeHeart:
                typeHeart.GetComponent<Image>().sprite = typeSprite[3];
                numbDraw(GameObject.Find("Controller").GetComponent<ControlScript>()._hp, numbSpriteT);
                break;
            default:
                break;
        }
    }
}
