using UnityEngine;

public class ControlBordes : MonoBehaviour
{
    [Header("Configurar en el editor")]
    public float radio = 1f;
    public bool mantenerEnPantalla = false;

    [Header("Configuraciones dinamicas")]
    public bool estaEnPantalla = true;
    public float anchoCamara;
    public float altoCamara;
    public bool salioDerecha, salioIzquierda, salioArriba, salioAbajo;

    void LateUpdate()
    {
        altoCamara = Camera.main.orthographicSize;
        anchoCamara = Camera.main.aspect * altoCamara;
        Vector3 centro = Camera.main.transform.position;
        Vector3 pos = transform.position;
        salioAbajo = salioArriba = salioIzquierda = salioDerecha = false;

        if (pos.x > centro.x + anchoCamara - radio)
        {
            pos.x = centro.x + anchoCamara - radio;
            salioDerecha = true;
        }
        if (pos.x < centro.x - anchoCamara + radio)
        {
            pos.x = centro.x - anchoCamara + radio;
            salioIzquierda = true;
        }
        if (pos.y > centro.y + altoCamara - radio)
        {
            pos.y = centro.y + altoCamara - radio;
            salioArriba = true;
        }
        if (pos.y < centro.y - altoCamara + radio)
        {
            pos.y = centro.y - altoCamara + radio;
            salioAbajo = true;
        }

        estaEnPantalla = !(salioDerecha || salioIzquierda || salioArriba || salioAbajo);
        if (mantenerEnPantalla && !estaEnPantalla)
        {
            transform.position = pos;
            estaEnPantalla = true;
        }
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 centro = Camera.main.transform.position;
        centro.z = 0;
        Gizmos.DrawWireCube(centro, new Vector3(anchoCamara * 2, altoCamara * 2, 0));
    }
}
