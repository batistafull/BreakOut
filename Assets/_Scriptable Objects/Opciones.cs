using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : ObjetoPersistente
{
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;

    public enum dificultad
    {
        facil,
        normal,
        dificil
    }

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = Mathf.Clamp(nuevaVelocidad, 1, 100);
    }

    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)Mathf.Clamp(nuevaDificultad, 0, 2);
    }

    public float ObtenerVelocidadBola()
    {
        // La dificultad aumenta la velocidad elegida en el slider.
        float velocidad = Mathf.Clamp(velocidadBola, 1, 100);
        if (NivelDificultad == dificultad.normal) return velocidad * 1.25f;
        if (NivelDificultad == dificultad.dificil) return velocidad * 1.5f;
        return velocidad;
    }
}
