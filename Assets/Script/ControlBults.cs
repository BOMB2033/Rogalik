using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBults : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    void OnTriggerStay2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Enemy")
        {
            Destroy(collider2D.gameObject);
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

}
