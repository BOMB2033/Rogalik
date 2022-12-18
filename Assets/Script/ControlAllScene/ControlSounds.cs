using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSounds : MonoBehaviour
{
    public List<AudioClip> Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        gameObject.GetComponent<AudioSource>().volume =  gameObject.GetComponent<ControlSetting>().volume;
    }

    public void NextMusic(AudioClip audioClip = null)
    {
        System.Random random = new System.Random();
        if(audioClip == null)
            if(GameObject.Find("MainScene") != null)
                gameObject.GetComponent<AudioSource>().clip = Music[0];
            else
                gameObject.GetComponent<AudioSource>().clip = Music[random.Next(2,Music.Count)];
        else
            gameObject.GetComponent<AudioSource>().clip = audioClip;
        gameObject.GetComponent<AudioSource>().Play();
    }
}
