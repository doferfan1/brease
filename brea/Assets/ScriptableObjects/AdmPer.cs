using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmPer : MonoBehaviour
{
    public List<puntajePersis> ObjectosGuardar;

    private void OnEnable()
    {
        for(int i = 0; i < ObjectosGuardar.Count; i++)
        {
            var so = ObjectosGuardar[i];
            so.cargar();
        }
    }

   public void OnDisable()
    {

        for (int i = 0; i < ObjectosGuardar.Count; i++)
        {
            var so = ObjectosGuardar[i];
            so.guardar();
        }
    }
}
