using UnityEngine;

public class Bloque_Acero : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resitencia = 10;
    }
    
    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
