using Unity.VisualScripting;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float velocidadPaddle = 0.9f;

    Transform transform;

    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = this.gameObject.transform;
    }

    [System.Obsolete]
    public virtual void OnCollisionEnter(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = -direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
    }

    // Update is called once per frame
    void Update()
    {
    
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPaddle * Time.deltaTime);

        Vector3 pos = transform.position;
        //pos.x = mousePos3D.x;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos;
    }
}
