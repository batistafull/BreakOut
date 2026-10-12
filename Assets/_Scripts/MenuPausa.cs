using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuOpciones;

    public void MostrarMenuPausa()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
        menuOpciones.SetActive(false);
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(false);
        Time.timeScale = 1;
    }

    public void RegresarAPantallaPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void MostrarMenuOpciones()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
}
