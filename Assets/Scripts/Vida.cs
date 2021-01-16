using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{

    public float vida;
    public Slider barraVida;
    public Image  ImagenGameOver;
    public Button TextoReinicio;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.value = vida;

        if (vida <= 0)
        {
            Destroy(gameObject);
            ImagenGameOver.gameObject.SetActive(true);
            TextoReinicio.gameObject.SetActive(true);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        vida -= 1;
    }
}
