using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int limiteX = 23;
    public float velocidadPaddle = 0.9f;

    public void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bola")) return;
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion.y = Mathf.Max(Mathf.Abs(direccion.y), 1f);
        direccion.z = 0;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion.normalized;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * velocidadPaddle * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -limiteX, limiteX);
        transform.position = pos;
    }
}
