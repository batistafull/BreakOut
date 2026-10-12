using UnityEngine;

public class AdministradorBloque : MonoBehaviour
{
    public GameObject MenuFinNivel;
    bool nivelTerminado;

    void Update()
    {
        if (transform.childCount == 0 && !nivelTerminado)
        {
            nivelTerminado = true;
            MenuFinNivel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
