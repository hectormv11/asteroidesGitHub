using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoController : MonoBehaviour
{
    public CircleCollider2D CircleCollider;
    public GameObject Escudo;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroide")
        {
            collision.gameObject.GetComponent<AsteroideControler>().Muerte();
            new WaitForSeconds(4);
            Escudo.SetActive(false);
        }

        if (collision.tag == "Bala Enemiga")
        {
            collision.gameObject.GetComponent<AsteroideControler>().Muerte();
            new WaitForSeconds(4);
            Escudo.SetActive(false);
        }
    }


}
