using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum TypeHeart
{
    Normal,
    GoldHeart,
    DarkHeart,
    TimeHeart
}
public enum TypeWeapons
{
    empty,
    Revolver,
    Ak69,
    Nagelwerfer,
    Pyras
}

public class ControlScript : MonoBehaviour
{
   
    public int _hp = 50;

	public TypeHeart heart;
    
    public bool isAutoShot = false;

    public TypeWeapons weapon1 = TypeWeapons.empty;
    public TypeWeapons weapon2 = TypeWeapons.empty;

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Controller");

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (_hp < 0)
        {
            Destroy(GameObject.Find("Player"));
        }
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
