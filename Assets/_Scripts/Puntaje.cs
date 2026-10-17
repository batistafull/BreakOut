using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoPuntajeActual;
    // Asignar PuntajeNivel1, PuntajeNivel2 o PuntajeNivel3 en cada escena.
    public PuntajeAlto puntajeAltoSO;

    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoPuntajeActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();

        puntajeAltoSO.Cargar();
        puntajeAltoSO.puntaje = 0;
        ActualizarTextos();
    }

    public void AumentarPuntaje(int puntos)
    {
        puntajeAltoSO.puntaje += puntos;
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            puntajeAltoSO.Guardar();
        }
        ActualizarTextos();
    }

    void ActualizarTextos()
    {
        textoPuntajeActual.text = $"Puntaje: {puntajeAltoSO.puntaje}";
        textoPuntajeAlto.text = $"Puntaje Alto: {puntajeAltoSO.puntajeAlto}";
    }
}
