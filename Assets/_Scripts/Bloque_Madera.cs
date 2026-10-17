using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        resitencia = 2;
        base.Start();
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }


}
