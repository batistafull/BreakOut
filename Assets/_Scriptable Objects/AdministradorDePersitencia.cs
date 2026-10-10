using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDePersitencia : MonoBehaviour
{
    public List<PuntajePersitente> objetosAGuardar;

    public void OnEnable()
    {
        for (int i = 0; i < objetosAGuardar.Count; i++)
        {
            var so = objetosAGuardar[i];
            so.Cargar();
        }
    }

    public void OnDisable()
    {
        for (int i = 0; i < objetosAGuardar.Count; i++)
        {
            var so = objetosAGuardar[i];
            so.Guardar();
        }
    }


}
