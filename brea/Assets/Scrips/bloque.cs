using UnityEngine;

public class bloque : MonoBehaviour
{
    public int recistencia = 1;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(recistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public virtual void rebotarbola()
    {

    }
}
