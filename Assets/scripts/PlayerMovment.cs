using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    CircleCollider2D colider;
    SpriteRenderer sprite;
    public float speed = 100;
    public float rotationSpeed = -500;
    public GameObject bala;
    public GameObject boquilla;
    public GameObject particulaMuerte;
    public string muertoVivo = "vivo";
    public GameObject Escudo;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        colider = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            rb.AddForce(transform.up * vertical * speed * Time.deltaTime);
            anim.SetBool("impulsing", true);
        }
        else
        {
            anim.SetBool("impulsing", false);
        }

        float horizontal = Input.GetAxis("Horizontal");
        transform.eulerAngles += new Vector3(0, 0, horizontal * rotationSpeed * Time.deltaTime);



        if (Input.GetMouseButtonDown(0))
        {
            if (muertoVivo == "vivo")
            {
                GameObject temp = Instantiate(bala, boquilla.transform.position, transform.rotation);
                Destroy(temp, 1.5f);
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            if (GameManager.instance.NumeroDeEscudos >= 0)
            {
                if (muertoVivo == "vivo")
                {
                    StartCoroutine(Respawn_Coroutine1());
                    GameManager.instance.NumeroDeEscudos -= 1;
                }
            }
            
        }
    }
    public void Muerte()
    {
        GameObject temp = Instantiate(particulaMuerte, transform.position, transform.rotation);
        Destroy(temp, 2.5f);

        GameManager.instance.vidas -= 1;

        if (GameManager.instance.vidas <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }

        else
        {
            StartCoroutine(Respawn_Coroutine());
        }
         
    }
        

    IEnumerator Respawn_Coroutine()
    {
        muertoVivo = "muerto";
        colider.enabled = false;
        sprite.enabled = false;
        yield return new WaitForSeconds(2);
        sprite.enabled = true;
        colider.enabled = true;
        muertoVivo = "vivo";

        transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector2(0, 0);
    }

    IEnumerator Respawn_Coroutine1()
    {
        Escudo.SetActive(true);

        yield return new WaitForSeconds(5);

        Escudo.SetActive(false);
    }


}
