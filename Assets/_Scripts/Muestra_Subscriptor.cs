using UnityEngine;

public class Muestra_Subscriptor : MonoBehaviour
{
    Muestra_Evento subscriptor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscriptor = GetComponent<Muestra_Evento>();
        subscriptor.OnSpacePressed += MensajeEscuchadoPorElSubscriptor;
    }

    private void MensajeEscuchadoPorElSubscriptor(object sender, System.EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado por el subscriptor");
        subscriptor.OnSpacePressed -= MensajeEscuchadoPorElSubscriptor;
    }


}
