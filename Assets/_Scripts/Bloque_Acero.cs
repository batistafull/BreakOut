using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Acero : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        resitencia = 5;
        base.Start();
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
