using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class puntaje : MonoBehaviour
{
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoPuntajeActual;
    public Transform transformpuntajeAlto;
    public Transform transformpuntajeActual;
    public puntajealto puntajealtoSO;
    //public int puntos=0;
    //public int puntajealto=10000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformpuntajeAlto= GameObject.Find("puntajealto").transform;
        transformpuntajeActual = GameObject.Find("puntajeActual").transform;
        textoPuntajeActual = transformpuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformpuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("puntajeAlto"))
        //{

        //    //puntajealto = PlayerPrefs.GetInt("puntajeAlto");
        //}
        puntajealtoSO.puntaje = 0;
        puntajealtoSO.cargar();
    }

    private void FixedUpdate()
    {
       puntajealtoSO.puntaje+=100;
    }
    // Update is called once per frame
    void Update()
    {
        textoPuntajeActual.text= $"Puntaje actual: {puntajealtoSO.puntaje}";
        textoPuntajeAlto.text = $"Puntaje mas Alto: {puntajealtoSO.puntajealtos}";
        if (puntajealtoSO.puntaje > puntajealtoSO.puntajealtos)
        {
            puntajealtoSO.puntajealtos = puntajealtoSO.puntaje;
            textoPuntajeAlto.text = $"Puntaje mas Alto: {puntajealtoSO.puntajealtos}";
            //PlayerPrefs.SetInt("puntajeAlto", puntajealto);

        }
        puntajealtoSO.guardar();
    }
}
