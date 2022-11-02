using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI Escudos;
    public GameObject Gameover;
    public GameObject nextlevel;
    public AsteriodManager manager;
     
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");

        if (GameManager.instance.vidas <= 0)
        {
            Gameover.SetActive(true);
        }

        vidas.text = GameManager.instance.vidas.ToString("0");
        puntuacion.text = GameManager.instance.puntuacion.ToString("0");
        


        if (manager.asteroides <= 0)
        {
           
            
            StartCoroutine(siguientenivel());
            GameManager.instance.NumeroDeEscudos += 1;
        }

    }


    IEnumerator siguientenivel()
    {
        nextlevel.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        nextlevel.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        nextlevel.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        nextlevel.SetActive(false);
    }


}
