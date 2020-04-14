using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Paddle myPaddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {


        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        Vector2 tweak = new Vector2(randomX, randomY);

        this.GetComponent<Rigidbody2D>().velocity += tweak;
    }

    void Start()
    {

        myPaddle = GameObject.FindObjectOfType<Paddle>();

        paddleToBallVector = this.transform.position - myPaddle.transform.position;

    }

    void Update()
    {

        if (!hasStarted)
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;


            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                Debug.Log(hasStarted);
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);

            }
        }



    }
}