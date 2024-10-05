using UnityEngine;

public class Muerte : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la colisión es con el objeto "Jugador"
        if (collision.gameObject.CompareTag("Jugador"))
        {
            // Desactivar el objeto del jugador
            collision.gameObject.SetActive(false);
        }
    }
}
