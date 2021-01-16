using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer Rata;
    private ScrPickup scrP;

    public float speed;
    public float rotationInterpolation = 0.4f;
    public bool isMoving;

    bool FlipRata = true;

    float RatAngle;

    Animator RataAnim;
    Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Rata = GetComponent<SpriteRenderer>();
        RataAnim = GetComponent<Animator>();
    }

    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (input.x != 0 || input.y != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (input.x > 0 && !FlipRata)
        {
            Giro();
        }
        else if (input.x < 0 && FlipRata)
        {
            Giro();
        }
        RataAnim.SetFloat("VelMovimiento", Mathf.Abs(input.x + input.y));
    }

    void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }

    void Giro()
    {
        FlipRata = !FlipRata;
        Rata.flipX = !Rata.flipX;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Rata.color = Color.red;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Rata.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if (collision.tag == "pickup") Destroy(collision.gameObject);
        if (collision.CompareTag("pickup"))
        {
            AudioSource Ñam; 

            Ñam = collision.GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(Ñam.clip, Camera.main.transform.position);


            scrP = collision.GetComponent<ScrPickup>();
            ScrControlGame.punts += scrP.valor;
            Destroy(collision.gameObject);
            ScrControlGame.pickups--;

        }
    }
}

