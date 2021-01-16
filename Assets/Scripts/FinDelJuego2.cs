using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinDelJuego2 : MonoBehaviour
{


    string[] escenes = { "Level3" };
    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Final"))

            SceneManager.LoadScene(3);
    }
}
