using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 7;
    [SerializeField] public float velocidad = 10f;

   
    Vector3 mousepos2d;
    Vector3 mousepos3d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform transform;
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {


        //mousepos2d = Input.mousePosition;
        //mousepos2d.z = -Camera.main.transform.position.z;
        //mousepos3d = Camera.main.ScreenToWorldPoint(mousepos2d);

        //if(Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(Vector3.down * velocidad *  Time.deltaTime);
        //}

        this.transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidad * Time.deltaTime);

        Vector3 pos = this.transform.position;

        //pos.x = mousepos3d.x;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }   else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos;
    }
}
