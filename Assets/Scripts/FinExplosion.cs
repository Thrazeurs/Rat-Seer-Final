using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinExplosion : MonoBehaviour
{

    public float Tiempo = 2;
    void Start()
    {
        Invoke("Die", Tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
