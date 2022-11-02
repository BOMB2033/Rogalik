using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public ControlType controlType;
    public Joystick joystick;
    public float speed;
    public float speedRoll = 2;
    public Animator animator;

    public enum ControlType { PC, Android }

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private Vector2 movePerk;
    private bool isPerk = false;
    private bool isClickDown = false;
    private GameObject Weapons;

    public float delay = 0.5f; //тут как тебе надо int,double или float
    private bool delayState = true;

    IEnumerator Delay()
    {
        delayState = false;

        yield return new WaitForSeconds(delay); //та самая временная задержка.

        delayState = true;
    }


    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
        Weapons = GameObject.Find("Weapons");
    }
    void idle()
    {

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeRoll")) // проверка НЕ выпоняется ли перекат
        {
            if (moveInput.x != 0 || moveInput.y != 0) // проверка сдвинут ли положение джостика
            {


                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerRun")) //  если не проигрывается анимация ходьбы 
                    animator.Play("PlayerRun"); // запустить анимацию хотьбы 
            }
            else // если стоит на месте 
            {
                animator.Play("Idol"); // проиграть анимацию стояния 
            }
        }
        if (moveInput.x != 0)
        {
              if (moveInput.x > 0) // если двигается туда -->
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false; // отрозить по Х
                Weapons.transform.localScale = new Vector2(Math.Abs(Weapons.transform.localScale.x), Weapons.transform.localScale.y);


            }
            else // если двигается туда <--
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true; // отрозить по Х
                Weapons.transform.localScale = new Vector2(-Math.Abs(Weapons.transform.localScale.x), Weapons.transform.localScale.y);
            }
        }
        

        if ((Input.GetKeyDown(KeyCode.LeftShift) || isClickDown ) && delayState) // если нажата кнопка переката 
        {
            isClickDown = false; // отжать кнопку переката
            if (moveInput.x != 0 || moveInput.y != 0) // если есть передвижение
            {
                StartCoroutine(Delay());
                DodgeRoll(); // сделать перекат
            }

        }
        else // если не нажата кнопка переката 
        {
            if (controlType == ControlType.PC)
            {
                moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            }
            else if (controlType == ControlType.Android)
            {
                moveInput = new Vector2(joystick.Horizontal, joystick.Vertical); // принять данны о напровлении
            }
            moveVelocity = moveInput.normalized * speed; // посчитать передвижение
        }

    }
    void Update()
    {
        idle();

        
    }


    private void DodgeRoll() // перекат
    {
        if (controlType == ControlType.PC)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else if (controlType == ControlType.Android)
        {
            moveInput = new Vector2(joystick.Horizontal, joystick.Vertical); // принять данные о напровлении
        }

        movePerk = moveInput.normalized * speedRoll; // кинуьт в передвижении
        animator.Play("DodgeRoll"); // анимация переката

        isPerk = true; // включить перекат
    }

    public void ClickDown ()
    {            
        isClickDown = true;
    }

    void FixedUpdate()
    {
        if (isPerk)
        {
            rb.MovePosition(rb.position + movePerk * Time.fixedDeltaTime);
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("DodgeRoll"))
            {
                isPerk = false;
            }
        }
        else
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }



    }
}