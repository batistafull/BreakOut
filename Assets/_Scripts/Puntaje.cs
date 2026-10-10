using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoPuntajeActual;
    public PuntajeAlto puntajeAltoSO;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoPuntajeActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
            //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
            
        //}
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"Puntaje Alto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;
        
    }

    public void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntajeActual.text = $"Puntaje: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"Puntaje Alto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntajeAltoSO.puntaje);
        }
        
    }
}
