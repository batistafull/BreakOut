using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Muestra_Evento : MonoBehaviour
{

    public UnityEvent MiEventoUnity;
    public event EventHandler OnSpacePressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
            MiEventoUnity?.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado");
    }

    public void EventoUnityEscuchado()
    {
        Debug.Log("El evento Unity ha sido escuchado");
    }
}
