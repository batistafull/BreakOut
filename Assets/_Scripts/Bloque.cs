using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int resitencia = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resitencia <= 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void RebotarBola()
    {
        
    }
}
