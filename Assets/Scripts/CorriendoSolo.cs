using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorriendoSolo : MonoBehaviour
{

    public bool isMoving;

    Animator RataAnim;
    Vector2 input;
    void Start()
    {
        RataAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (input.x != 0 || input.y != 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        RataAnim.SetFloat("VelMovimiento", Mathf.Abs(input.x + input.y));
    }
}
