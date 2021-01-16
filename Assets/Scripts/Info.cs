using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{


    string[] escenes = { "Level3" };
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))

            SceneManager.LoadScene(1);
    }
}
