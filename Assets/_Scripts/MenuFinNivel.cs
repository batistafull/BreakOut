using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinNivel : MonoBehaviour
{
    public void SiguienteNivel()
    {
        var siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if(SceneManager.sceneCountInBuildSettings > siguienteNivel)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(siguienteNivel);
        }
        else
        {
            CargarMenuPrincipal();
        }
    }

    public void CargarMenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ReintentarNivel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
