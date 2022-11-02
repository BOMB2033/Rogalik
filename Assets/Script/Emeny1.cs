using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny1 : MonoBehaviour
{
    private Animator animator;
    private GameObject player;
    public float speedEnemy = 0.025f;
    private float dist;
    private bool delayState = true;
    public float delay = 0.5f; //тут как тебе надо int,double или float

    IEnumerator AttackDelay()
    {
        delayState = false;
        yield return new WaitForSeconds(delay); //та сама€ временна€ задержка.
        GameObject.Find("Controller").GetComponent<ControlScript>()._hp--;
        delayState = true;
    }
        // Start is called before the first frame update
        void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector2.Distance(transform.position, player.transform.position);
        if (dist<0.4f)
        {
                if (delayState) //«асунуть в нужное место
                    StartCoroutine(AttackDelay());
               
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speedEnemy); //в скобках через зап€тую указаны: текущее положение, куда идти, с какой скоростью
    }
}
