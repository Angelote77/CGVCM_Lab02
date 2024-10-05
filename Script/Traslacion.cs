using UnityEngine;

public class Traslacion : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public float distanciaMovimiento = 5f; // Distancia de movimiento

    private Vector3 objetivo;
    private Vector3 direccion = Vector3.right;

    void Start()
    {
        objetivo = transform.position + Vector3.right * distanciaMovimiento;
    }

    void Update()
    {
        // Mover hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);

        // Si alcanza el objetivo, cambia la dirección
        if (transform.position == objetivo)
        {
            CambiarDireccion();
        }
    }

    void CambiarDireccion()
    {
        if (direccion == Vector3.right)
        {
            // Cambia a mover hacia arriba
            objetivo = transform.position + Vector3.up * distanciaMovimiento;
            direccion = Vector3.up;
        }
        else if (direccion == Vector3.up)
        {
            // Cambia a mover hacia la izquierda
            objetivo = transform.position + Vector3.left * distanciaMovimiento;
            direccion = Vector3.left;
        }
        else if (direccion == Vector3.left)
        {
            // Cambia a mover hacia abajo
            objetivo = transform.position + Vector3.down * distanciaMovimiento;
            direccion = Vector3.down;
        }
        else if (direccion == Vector3.down)
        {
            // Cambia a mover hacia la derecha
            objetivo = transform.position + Vector3.right * distanciaMovimiento;
            direccion = Vector3.right;
        }
    }
}
