using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform ballPong; // Change the variable name to match the ball object's name

    // Adjust this value to control the speed of the AI paddle
    public float paddleSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (ballPong != null)
        {
            // Move the paddle towards the ball's y-position
            float targetY = Mathf.MoveTowards(transform.position.y, ballPong.position.y, paddleSpeed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
        }
        else
        {
            Debug.LogWarning("Ball reference is not set!");
        }
    }
}

