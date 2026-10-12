using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Gelatina : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resitencia = 2;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
    
}
