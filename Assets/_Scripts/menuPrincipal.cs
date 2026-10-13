using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public GameObject menuOpciones;
    public GameObject menuInicial;

    public void IniciarJuego()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    public void MostrarOpciones()
    {
        menuInicial.SetActive(false);
        menuOpciones.SetActive(true);
        
    }

}
