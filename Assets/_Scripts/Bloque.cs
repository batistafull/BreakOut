using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resitencia = 1;
    public UnityEvent AumentarPuntaje;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bola") && resitencia > 0)
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        collision.gameObject.GetComponent<Bola>().Rebotar(collision.contacts[0].normal);
        resitencia--;
        if (resitencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(gameObject);
        }
    }
}
