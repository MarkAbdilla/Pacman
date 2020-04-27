using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 2f;

    private void Update()
    {
        MoveRightAndLeft();
        MoveUpAndDown();
    }

    private void MoveRightAndLeft()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);
    }

    private void MoveUpAndDown()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;
        transform.Translate(0, translation, 0);
    }
}
