using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bulletcontroler : MonoBehaviour
{
    public CapsuleCollider2D capsuleCollider;
    public float speed = 10;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Asteroide")
        {
            collision.gameObject.GetComponent<AsteroideControler>().Muerte();
            Destroy(gameObject);
        }

        if (collision.tag == "Enemigo")
        {
            collision.gameObject.GetComponent<EnemigoControler>().Muerte();
            Destroy(gameObject);
        }

    }
}
