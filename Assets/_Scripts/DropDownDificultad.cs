using UnityEngine;
using TMPro;

public class DropDownDificultad : MonoBehaviour
{
    public Opciones opciones;
    public TMP_Dropdown dificultad;

    void OnEnable()
    {
        dificultad = GetComponent<TMP_Dropdown>();
        dificultad.SetValueWithoutNotify((int)opciones.NivelDificultad);
        dificultad.onValueChanged.AddListener(opciones.CambiarDificultad);
    }

    void OnDisable()
    {
        dificultad.onValueChanged.RemoveListener(opciones.CambiarDificultad);
    }
}
