using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    const float velocidadBase = 1.0f;
    const float reduccionVelocidad = 0.25f;

    public float velocidadMovimiento = velocidadBase /*+boost*/;
    public float velocidadDiagonal = velocidadBase - reduccionVelocidad;


    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        //movimiento en todas direcciones
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidadMovimiento * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidadMovimiento * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * velocidadMovimiento * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * velocidadMovimiento * Time.deltaTime;
        }

        //para movimiento en diagonal, que se mas lento
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            velocidadMovimiento = velocidadDiagonal;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            velocidadMovimiento = velocidadDiagonal;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            velocidadMovimiento = velocidadDiagonal;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            velocidadMovimiento = velocidadDiagonal;
        }
        else
        {
            velocidadMovimiento = velocidadBase /* + boost */;
        }

    }
}
