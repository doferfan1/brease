using UnityEngine;

public class pelota : bloque
{
    Color original;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      this.GetComponent<Renderer>().material.color=Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
