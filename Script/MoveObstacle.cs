using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    private float speed = 6f;
    private bool going_right = false;

    void Update()
    {
        if (going_right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed); // Move right
            if (transform.position.x > 15) // Too far right
            {
                going_right = false; // Switch direction
            }
        }
        else
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed); // Move left
            if (transform.position.x < -14) // Too far left
            {
                going_right = true; // Switch direction
            }
        }
    }
}
