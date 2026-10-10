using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resitencia = 3;
    }

    [System.Obsolete]
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }


}
