using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    bool isGameStarted;
    public Opciones opciones;
    public float velocidadBola = 30;
    Vector3 direccion = Vector3.up;
    Rigidbody cuerpo;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();
        cuerpo = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isGameStarted = false;
        Transform jugador = GameObject.FindGameObjectWithTag("Jugador").transform;
        Vector3 posicionInicial = jugador.position;
        posicionInicial.y += 3;
        transform.position = posicionInicial;
        transform.SetParent(jugador);
        cuerpo.linearVelocity = Vector3.zero;
    }

    void Update()
    {
        if (opciones != null) velocidadBola = opciones.ObtenerVelocidadBola();
        if (Time.timeScale == 0) return;

        if (control.salioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(gameObject);
            return;
        }

        Vector3 movimiento = cuerpo.linearVelocity;
        if (control.salioArriba) movimiento.y = -Mathf.Abs(movimiento.y);
        if (control.salioIzquierda) movimiento.x = Mathf.Abs(movimiento.x);
        if (control.salioDerecha) movimiento.x = -Mathf.Abs(movimiento.x);
        if (isGameStarted) cuerpo.linearVelocity = movimiento.normalized * velocidadBola;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                transform.SetParent(null);
                direccion = new Vector3(0.25f, 1, 0).normalized;
                cuerpo.linearVelocity = velocidadBola * direccion;
            }
        }
    }

    void FixedUpdate()
    {
        // Guardamos la direccion antes de que la fisica resuelva el choque.
        if (cuerpo.linearVelocity != Vector3.zero)
            direccion = cuerpo.linearVelocity.normalized;
    }

    public void Rebotar(Vector3 normal)
    {
        direccion = Vector3.Reflect(direccion, normal);
        direccion.z = 0;
        // Evita que la bola quede rebotando completamente horizontal.
        if (Mathf.Abs(direccion.y) < 0.2f)
            direccion.y = direccion.y < 0 ? -0.2f : 0.2f;
        cuerpo.linearVelocity = direccion.normalized * velocidadBola;
    }
}
