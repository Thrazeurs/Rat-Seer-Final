using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Piedra2 : MonoBehaviour
{
    private Image ImagenPiedra;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ScrControlGame.punts >= 8)

            Destroy(gameObject);
    }
}