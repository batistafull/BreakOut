using System.Collections.Generic;
using UnityEngine;

public class AdministradorVida : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas = new List<GameObject>();
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;

    void Start()
    {
        vidas.Clear();
        // Solo contamos los corazones, sin incluir AdminVidas.
        foreach (Transform hijo in transform)
        {
            vidas.Add(hijo.gameObject);
        }
    }

    public void EliminarVida()
    {
        if (vidas.Count == 0) return;
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if (vidas.Count == 0)
        {
            MenuFinJuego.SetActive(true);
            Time.timeScale = 0;
            return;
        }
        var bola = Instantiate(bolaPrefab);
        bolaScript = bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(EliminarVida);
    }
}
