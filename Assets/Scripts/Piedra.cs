using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Piedra : MonoBehaviour
{

    private Image ImagenPiedra;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScrControlGame.punts >= 2)

            Destroy(gameObject);
    }
}
