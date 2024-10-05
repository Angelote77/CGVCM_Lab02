using UnityEngine;

public class Escalar : MonoBehaviour
{
    public float escalaMaxima = 2f; // Escala máxima del objeto
    public float velocidadEscalado = 1f; // Velocidad de escala

    private Vector3 escalaInicial;
    private bool creciendo = true; // Indica si el objeto está creciendo o encogiendo

    void Start()
    {
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        // Escalar el objeto
        if (creciendo)
        {
            // Incrementar la escala
            transform.localScale += Vector3.one * velocidadEscalado * Time.deltaTime;

            // Si alcanza la escala máxima, establecer creciendo a falso
            if (transform.localScale.x >= escalaMaxima)
                creciendo = false;
        }
        else
        {
            // Reducir la escala
            transform.localScale -= Vector3.one * velocidadEscalado * Time.deltaTime;

            // Si alcanza la escala inicial, establecer creciendo a verdadero
            if (transform.localScale.x <= escalaInicial.x)
                creciendo = true;
        }
    }
}
