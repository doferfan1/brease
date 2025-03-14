using UnityEngine;

public class bloquehielo : bloque
{
   public GameObject cubo1;
   public GameObject cubo2;
   public GameObject cubo3;

    void Start()
    {
        recistencia = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(recistencia <= 0)
        {
            cubo1.GetComponent<bloque>().recistencia-= 1;
            cubo2.GetComponent<bloque>().recistencia -= 1;
            cubo3.GetComponent<bloque>().recistencia -= 1;
            Destroy(this.gameObject);
           
        }
    }

}
