using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float velY;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Reiniciar la velocidad vertical a 0 cada frame
        rb.velocity = new Vector2(0, 0);

        // Mover la raqueta hacia arriba si se presiona la tecla W/Flecha arriba
        if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(0, velY);
        }

        // Mover la raqueta hacia abajo si se presiona la tecla S/Flecha abajo
        if (Input.GetKey(down))
        {
            rb.velocity = new Vector2(0, -velY);
        }
    }
}