using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    const float velocidadBase = 1.0f;
    const float reduccionVelocidad = 0.25f;

    public float velocidadMovimiento = velocidadBase /*+boost*/;
    public float velocidadDiagonal = velocidadBase - reduccionVelocidad;

    public float personajePosX;
    public float personajePosY;

    public Sprite frontHead;
    public Sprite backHead;
    public Sprite leftHead;
    public Sprite rightHead;

    public Sprite frontBody;
    public Sprite backBody;
    public Sprite leftBody;
    public Sprite rightBody;

    public  SpriteRenderer esaCabesa;
    SpriteRenderer eseBody;

    void Start()
    {
        Vector3 v = Camera.main.WorldToScreenPoint(transform.position);
        personajePosX = v.x;
        personajePosY = v.y;

        eseBody = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Movimiento();
        MovimientoCabeza();
    }

    void Movimiento()
    {
        //movimiento en todas direcciones
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidadMovimiento * Time.deltaTime;
            eseBody.sprite = leftBody;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidadMovimiento * Time.deltaTime;
            eseBody.sprite = rightBody;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * velocidadMovimiento * Time.deltaTime;
            eseBody.sprite = backBody;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * velocidadMovimiento * Time.deltaTime;
            eseBody.sprite = frontBody;
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





    void MovimientoCabeza()
    {
        float diferenciaX = Input.mousePosition.x - personajePosX;
        float diferenciaY = Input.mousePosition.y - personajePosY;
       
        //movimiento de la cabeza hacia abajo
        if (-80 < diferenciaX && diferenciaX < 80)
        {
            esaCabesa.sprite = frontHead;
        }
        //movimiento de la cabeza hacia la derecha
        if (diferenciaX > 80)
        {
            esaCabesa.sprite = rightHead;
        }

        //movimiento de la cabeza hacia la izquierda
        if (diferenciaX < -80)
        {
            esaCabesa.sprite = leftHead;
        }

        //movimiento de la cabeza hacia arriba
        if (diferenciaY > 180)
        {
            esaCabesa.sprite = backHead;
        }

    }


}

