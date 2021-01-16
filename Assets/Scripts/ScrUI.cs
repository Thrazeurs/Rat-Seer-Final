using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrUI : MonoBehaviour
{
    [SerializeField]
    Text puntuacio,tiempo,pickups; // para acceder al elemnto de la UI

    float crono = 0;


    // Start is called before the first frame update
    void Start()
    {
        
  
    }

    // Update is called once per frame
    void Update()
    {
        crono += Time.deltaTime;
        puntuacio.text = "Puntuación: " + ScrControlGame.punts;
        pickups.text = "Restantes: " + ScrControlGame.pickups.ToString();
        tiempo.text = "Tiempo: " + crono.ToString("0.0");
    }
}

