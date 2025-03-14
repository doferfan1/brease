//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.Rendering;
//using UnityEngine;

//public class bloquedup : bloque
//{
//    public GameObject pelota;
//    int a, b, c;

//    public float tiemposegundos;

//    void Start()
//    {
//        recistencia = 1;



//    }

//    // Update is called once per frame
//    void Update()
//    {

//        Color original = pelota.GetComponent<Renderer>().material.color;

//        if (recistencia <= 0)
//        {


//            a = Random.Range(0, 255);
//            b = Random.Range(0, 255);
//            c = Random.Range(0, 255);
//            Color color = new Color(a, b, c);


//            pelota.GetComponent<Renderer>().material.color = color;
//            this.gameObject.GetComponent<Transform>().position = new Vector3(180, 0, 0);


//            StartCoroutine(DesactivarDespuesDeTiempo(tiemposegundos, original));














//        }


//    }
//    private IEnumerator DesactivarDespuesDeTiempo(float tiempo, Color col)
//    {

//        yield return new WaitForSeconds(tiempo);
//        pelota.GetComponent<Renderer>().material.color = col;

//        this.gameObject.SetActive(false);
//        pelota.GetComponent<Renderer>().material.color = Color.white;
//        Destroy(this.gameObject);
//    }
//    private void OnDisable()
//    {




//    }


//}
