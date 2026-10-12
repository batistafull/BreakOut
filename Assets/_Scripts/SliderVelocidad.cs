using UnityEngine;
using UnityEngine.UI;

public class SliderVelocidad : MonoBehaviour
{
    public Opciones opciones;
    Slider slider;

    void OnEnable()
    {
        slider = GetComponent<Slider>();
        slider.SetValueWithoutNotify(opciones.velocidadBola);
        slider.onValueChanged.AddListener(CambiarVelocidad);
    }

    void OnDisable()
    {
        slider.onValueChanged.RemoveListener(CambiarVelocidad);
    }

    void CambiarVelocidad(float valor)
    {
        opciones.CambiarVelocidad(valor);
    }

    public void ControlarCambios()
    {
        opciones.CambiarVelocidad(slider.value);
    }
}
