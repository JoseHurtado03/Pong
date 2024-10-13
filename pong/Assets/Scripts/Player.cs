using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float velY;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, velY);
        }

        if (Input.GetKey(down))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -velY);
        }
    }
}
    
