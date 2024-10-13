using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
public float vel;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(vel, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreP1"))
        {
            GameManager.Instance.PointP1();
            transform.position = Vector2.zero;
        }

        if (collision.gameObject.CompareTag("ScoreP2"))
        {
            GameManager.Instance.PointP2();
            transform.position = Vector2.zero;
        }
    }

}
