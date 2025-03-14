using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestaSub : MonoBehaviour
{
    Muestraeventos subscriptor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscriptor= GetComponent<Muestraeventos>();
        subscriptor.enCasodeEspacio += MensajeEscuchadoPorSub;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void MensajeEscuchadoPorSub(object senderm, EventArgs e)
    {
        Debug.Log("Mensaje escuchado por subscriptor");
    }

}
