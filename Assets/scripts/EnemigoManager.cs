using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoManager : MonoBehaviour
{
    public int enemigos_max = 8;
    public int enemigos_min = 7;
    public int enemigo;
    public float limitX = 10;
    public float limitY = 6;
    public GameObject NaveEnemiga;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.puntuacion == 2000)
        {
            if (enemigo == 0)
            { 
                StartCoroutine(Text());
            }
        }
    }

    void CrearNaveEnemiga()
    {
        int enemigo = Random.Range(enemigos_min, enemigos_max);

        for (int i = 0; i < enemigo; i++)
        {
            Debug.Log("Instanciado enemigo: " + i);
            Vector3 posicion = new Vector3(-8, -4);
            Vector3 rotacion = new Vector3(0, 0, 0);
            GameObject temp = Instantiate(NaveEnemiga, posicion, Quaternion.Euler(rotacion));
            temp.GetComponent<EnemigoControler>().manager = this;
        }
    }

    IEnumerator Text()
    {
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
        CrearNaveEnemiga();
        yield return new WaitForSeconds(30);
    }
     
    

}
