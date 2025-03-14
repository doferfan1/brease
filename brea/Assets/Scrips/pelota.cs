using UnityEngine;

public class pelota : MonoBehaviour
{
 public bool enjuego = false;
    [SerializeField]public float velocidad = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 posicioninicial= GameObject.FindGameObjectWithTag("jugador").transform.position;
        posicioninicial.y += 3;
        this.transform.position = posicioninicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("jugador").transform);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetButton("Submit"))
        {
           if (!enjuego)
            {
                enjuego = true;
                this.transform.SetParent(null);
                this.GetComponent<Rigidbody>().linearVelocity = Vector3.up * velocidad;
            }
        }   
    }
}
