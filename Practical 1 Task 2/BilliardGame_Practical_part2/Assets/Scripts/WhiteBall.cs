using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour
{
 

    bool hasStarted = false;
    int chances = 5;


    void Start()
    {


    }

    void Update()
    {
        if (!hasStarted) 
        {
            LaunchBallOnClick();
        }
    }

    private void LaunchBallOnClick()
    {
            if (Input.GetMouseButtonDown(0))
            {


                var x = Random.Range(-1, 2);
                var y = Random.Range(15, 21);
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);

            }
            
        }
    }