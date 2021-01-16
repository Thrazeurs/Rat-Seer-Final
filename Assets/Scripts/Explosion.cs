using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public GameObject Player;
    public float Daño = 1;
    public float vida
    {
        get { return _vida; }
        set
        {
            _vida = value;

            if(_vida <= 0.0)
            {
                if (Player != null)
                {
                    Instantiate(Player, transform.position, transform.rotation);
                    Destroy (gameObject);
                }
            }
        }
    }
    [SerializeField]
    private float _vida = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            vida = 0.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D Enemy)
    {
        if (Enemy.gameObject.tag == "Enemy")
            vida -= 1;
    }
}

