using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public float distanciaDeteccion = 0.1f; // Distancia para detectar la pared
    public LayerMask capasPared; // Capas que representan las paredes

    private Rigidbody2D rb;
    private bool moviendoDerecha = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        Vector2 movimiento = Vector2.right * velocidad * Time.deltaTime;
        if (!moviendoDerecha)
            movimiento *= -1f; // Invertir el movimiento si va hacia la izquierda
        rb.MovePosition(rb.position + movimiento);

        // Detección de la pared
        Vector2 direccion = moviendoDerecha ? Vector2.right : Vector2.left;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direccion, distanciaDeteccion, capasPared);
        if (hit.collider != null)
        {
            // Cambiar de dirección si detecta una pared
            moviendoDerecha = !moviendoDerecha;
        }
    }
}
