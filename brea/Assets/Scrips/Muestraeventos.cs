using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class Muestraeventos : MonoBehaviour
{
    public event EventHandler enCasodeEspacio;
    public UnityEvent MIEvento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enCasodeEspacio += DisparoEvento;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            enCasodeEspacio?.Invoke(this, EventArgs.Empty);
            MIEvento.Invoke();
           
        }
    }

    public void DisparoEvento(object sender, EventArgs e)
    {
        Debug.Log("Se disparo el evento");
      
    }
    public void EventoUnity()
    {
       Debug.Log("Evento unity");
        
    }
}

