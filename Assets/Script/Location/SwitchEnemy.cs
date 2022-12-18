using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEnemy : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public Transform[] spawnPoints = new Transform[9];
    public Vector2 localpos;
    public Vector2 pos;

    public int length = 3;
    public bool isBigin = false;
    public List<GameObject> t = new List<GameObject>();
    private bool isMusicOn = false;
    private ControlSounds controlSounds;
    // Start is called before the first frame update
    void Start()
    {
        controlSounds = GameObject.Find("Controller").GetComponent<ControlSounds>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBigin && t.Count == 0)
        {
            door1.SetActive(false);
            door2.SetActive(false);
            if(!isMusicOn){
            controlSounds.NextMusic();
            isMusicOn = true;}
        }
        if (t[0] == null)
        {
            t.RemoveAt(0);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isBigin)
        {
            isBigin = true;
            door1.SetActive(true);
            door2.SetActive(true);
            controlSounds.NextMusic(controlSounds.Music[1]);
            for (int i = 0; i < length; i++)
            {
                t.Add(Instantiate(Enemy1, spawnPoints[Random.Range(0, spawnPoints.Length)]));
                t[i].transform.localPosition = Vector2.zero;
            }
            
        }
    }
}
