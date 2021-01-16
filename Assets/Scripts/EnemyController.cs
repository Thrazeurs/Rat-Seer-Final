using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxSpeed = 1f;
    public float speed = 1f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed);
        rb.velocity = new Vector2(limitedSpeed, rb.velocity.y);

        if (rb.velocity.x > -0.01f && rb.velocity.x < 0.01f)
        {
            speed = -speed;
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        else if (speed < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
