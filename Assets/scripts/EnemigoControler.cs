using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemigoControler : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public EnemigoManager manager;
    CircleCollider2D colider;
    SpriteRenderer sprite;
    public GameObject balaenemiga;
    public GameObject boquillaenemiga;
    public EnemigoManager EnemigoManager;
    public GameObject particulaMuerte;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direccion = new Vector2(5f, 0);
        direccion = direccion * speed;
        Debug.Log(direccion);
        rb.AddForce(direccion);
        manager.enemigo += 1;


        StartCoroutine(Respawn_Coroutine());



    }

    // Update is called once per frame
    void Update()
    {


        
        
    }

    public void Muerte()
    {
        GameObject temp = Instantiate(particulaMuerte, transform.position, transform.rotation);
        Destroy(temp, 2.5f);

        GameManager.instance.puntuacion += 500;
        manager.enemigo -= 1;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovment>().Muerte();
            
        }
    }

    IEnumerator Respawn_Coroutine()
    {
        GameObject temp = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp1 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp1, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp2 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp2, 1.5f);
        GameObject temp3 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp3, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp4 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp4, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp5 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp5, 1.5f);
        GameObject temp6 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp6, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp7 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp7, 1.5f);
        yield return new WaitForSeconds(2);
        GameObject temp8 = Instantiate(balaenemiga, boquillaenemiga.transform.position, transform.rotation);
        Destroy(temp8, 1.5f);

    }

}
